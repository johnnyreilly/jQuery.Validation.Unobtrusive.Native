param([string]$buildFolder)

git config --global push.default matching

cd "$($buildFolder)\..\"
mkdir gh-pages
git clone --quiet --branch=gh-pages https://github.com/johnnyreilly/jQuery.Validation.Unobtrusive.Native.git .\gh-pages\
cd gh-pages
git status

Get-ChildItem -Attributes !r | Remove-Item -Recurse -Force

copy-item -path ..\static-site\* -Destination $pwd.Path -Recurse

git status
$thereAreChanges = git status | select-string -pattern "Changes not staged for commit:","Untracked files:" -simplematch
if ($thereAreChanges -ne $null) { 
    Write-host "Committing changes to documentation..."
    git add --all
    git status
    git commit -m "skip ci - static site regeneration"
    git status
    git push
} 
else { 
    write-host "No changes to documentation to commit"
}
