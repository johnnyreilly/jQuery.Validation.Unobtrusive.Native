param([string]$buildFolder)

$jVUNDemo = "$($buildFolder)\jVUNDemo"
$staticSiteParentPath = (get-item $buildFolder).Parent.FullName
$staticSite = "static-site"
$staticSitePath = "$($staticSiteParentPath)\$($staticSite)"
$port = 57612
$servedAt = "http://localhost:$($port)/"
write-host "jVUNDemo location: $jVUNDemo"
write-host "static site parent location: $staticSiteParentPath"
write-host "static site location: $staticSitePath"

write-host "Spin up jVUNDemo site at $($servedAt)"
$iisExpressScript = {
    return & 'C:\Program Files (x86)\IIS Express\iisexpress.exe' /path:$jVUNDemo /port:$port
}
$job = Start-Job -Name RunIisExpress -Scriptblock $iisExpressScript

write-host "Wait a moment for IIS to startup"
write-host "Job state: $($job.state)"
Wait-Job $job -Timeout 5
write-host "Job state: $($job.state)"

if (Test-Path $staticSitePath) { 
    write-host "Removing $($staticSitePath)..."
    Remove-Item -path $staticSitePath -Recurse -Force
}

write-host "Create static version of demo site here: $($staticSitePath)"
Push-Location $staticSiteParentPath
wget.exe --recursive --convert-links -E --directory-prefix=$staticSite --no-host-directories --debug $servedAt
Pop-Location

write-host "Shut down jVUNDemo site"
write-host "Job state: $($job.state)"
Stop-Job $job
do {
    Start-sleep -s 5
} while ($job.state -eq "Running")
write-host "Job state: $($job.state)"
receive-job $job | out-file jobs.log -append
cat jobs.log
Remove-Job $job

if (Test-Path $staticSitePath) { 
    write-host "Contents of $($staticSitePath)"
    ls $staticSitePath
}
