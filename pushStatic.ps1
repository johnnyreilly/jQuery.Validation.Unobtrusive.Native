param([string]$buildFolder, [string]$email, [string]$username, [string]$personalAccessToken)

Write-Host "- Set config settings...."
git config --global user.email $email
git config --global user.name $username
git config --global push.default matching

Write-Host "- Clone gh-pages branch...."
cd "$($buildFolder)\..\"
mkdir gh-pages
git clone --quiet --branch=gh-pages https://$($username):$($personalAccessToken)@github.com/johnnyreilly/jQuery.Validation.Unobtrusive.Native.git .\gh-pages\
cd gh-pages
git status

Write-Host "- Clean gh-pages folder...."
Get-ChildItem -Attributes !r | Remove-Item -Recurse -Force

Write-Host "- Copy contents of static-site folder into gh-pages folder...."
copy-item -path ..\static-site\* -Destination $pwd.Path -Recurse

git status
$thereAreChanges = git status | select-string -pattern "Changes not staged for commit:","Untracked files:" -simplematch
if ($thereAreChanges -ne $null) { 
    Write-host "- Committing changes to documentation..."
    git add --all
    git status
    git commit -m "skip ci - static site regeneration"
    git status
    Write-Host "- Push it...."
    git push --quiet
    Write-Host "- Pushed it good?"
} 
else { 
    write-host "- No changes to documentation to commit"
}
