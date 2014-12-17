jQuery Validation Unobtrusive Native Docs / Demo
================================================

Well hello!

This is a documentation project for jQVUN which demonstrates how you might use the library.  It's written in ASP.Net MVC (perhaps unsurprisingly) but is, to all intents and purposes pretty much a static site. (Well the Remote and Globalize demos are slightly the exception to the rule but generally that's true.)

I'm planning to use GitHub Pages to host this.  The easiest way to do this is to use a tool to generate a static site that we can put on GitHub Pages.

# Generating the static site

You're going to need a copy of [wget](http://users.ugent.be/~bpuype/wget/).

Build your app then enter this at the command line: (Visual Studio should be closed)

```
# Generate the static site
cd C:\GitHub\jQuery.Validation.Unobtrusive.Native 
.\makeStatic.ps1 $pwd.path

# Switch to gh-pages branch and remove contents of directory
git checkout gh-pages
Get-ChildItem -Attributes !r | Remove-Item -Recurse -Force

# Copy contents of C:\GitHub\static-site to C:\GitHub\jQuery.Validation.Unobtrusive.Native
copy-item -path C:\GitHub\static-site\* -Destination C:\GitHub\jQuery.Validation.Unobtrusive.Native -Recurse

# Commit and push
git commit -a -m "skip ci - static site regeneration"
git push
```

This will create a static version of the website in a directory called "static-site". The contents of this directory should be pushed to the [gh-pages branch](https://github.com/johnnyreilly/jQuery.Validation.Unobtrusive.Native/tree/gh-pages) where it will be served up at [johnnyreilly.github.io/jQuery.Validation.Unobtrusive.Native/](http://johnnyreilly.github.io/jQuery.Validation.Unobtrusive.Native/).