param([string]$buildFolder)

$jVUNDemo = "$($buildFolder)\jVUNDemo"
$staticSiteParent = (get-item $buildFolder).Parent.FullName
$staticSite = "$($staticSiteParent)\static-site"
write-host "jVUNDemo location: $jVUNDemo"
write-host "static site parent location: $staticSiteParent"
write-host "static site location: $staticSite"

write-host "Spin up jVUNDemo site"
$job = Start-Job -Name RunIisExpress -Scriptblock {& 'C:\Program Files (x86)\IIS Express\iisexpress.exe' /path:$jVUNDemo /port:57612}

write-host "Wait a moment for IIS to startup"
Wait-Job $job -Timeout 5

if (Test-Path $staticSite) { 
    write-host "Removing $($staticSite)..."
    Remove-Item -path $staticSite -Recurse -Force
}

write-host "Create static version of demo site here: $($staticSite)"
Push-Location $staticSiteParent
wget.exe --recursive --convert-links -E --directory-prefix=static-site --no-host-directories http://localhost:57612/
Pop-Location

write-host "Shut down jVUNDemo site"
Stop-Job $job
while ($job.state -ne "Stopped") {}
receive-job $job
Remove-Job $job

if (Test-Path $staticSite) { 
    ls $staticSite
}
