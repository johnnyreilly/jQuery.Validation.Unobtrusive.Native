param([string]$buildFolder)

$jVUNDemo = "$($buildFolder)\jVUNDemo"
$staticSiteParentPath = (get-item $buildFolder).Parent.FullName
$staticSite = "static-site"
$staticSitePath = "$($staticSiteParentPath)\$($staticSite)"
$wgetLogPath = "$($staticSiteParentPath)\wget.log"
$port = 57612
$servedAt = "http://localhost:$($port)/"
write-host "jVUNDemo location: $jVUNDemo"
write-host "static site parent location: $staticSiteParentPath"
write-host "static site location: $staticSitePath"
write-host "wget log path: $wgetLogPath"

write-host "Spin up jVUNDemo site at $($servedAt)"
$process = Start-Process 'C:\Program Files (x86)\IIS Express\iisexpress.exe' -NoNewWindow -ArgumentList "/path:$($jVUNDemo) /port:$($port)"

write-host "Wait a moment for IIS to startup"
Start-sleep -s 15

if (Test-Path $staticSitePath) { 
    write-host "Removing $($staticSitePath)..."
    Remove-Item -path $staticSitePath -Recurse -Force
}

write-host "Create static version of demo site here: $($staticSitePath)"
Push-Location $staticSiteParentPath
# 2>&1 used to combine stderr and stdout
#wget.exe --recursive --convert-links -E --directory-prefix=$staticSite --no-host-directories --debug $servedAt
wget.exe --recursive --convert-links -E --directory-prefix=$staticSite --no-host-directories $servedAt > $wgetLogPath 2>&1
write-host "lastExitCode: $($lastExitCode)"
cat $wgetLogPath
Pop-Location

write-host "Shut down jVUNDemo site"
stop-process -Name iisexpress

if (Test-Path $staticSitePath) { 
    write-host "Contents of $($staticSitePath)"
    ls $staticSitePath
}
