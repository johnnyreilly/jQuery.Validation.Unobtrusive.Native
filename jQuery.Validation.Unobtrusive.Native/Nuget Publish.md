##To create the MVC 5 package:

-	Remove System.Web.Mvc and System.Web.WebPages references
-	Add System.Web.Mvc 5.0.0.0 reference
-	Add System.Web.WebPages 3.0.0.0 reference
-	Change nuspec id and title to jQuery.Validation.Unobtrusive.Native.MVC5 in jQuery.Validation.Unobtrusive.Native.nuspec
-	Compile in release mode

Then run the following commands to generate and publish based on project:

```
nuget pack jQuery.Validation.Unobtrusive.Native.csproj -Prop Configuration=Release
nuget push jQuery.Validation.Unobtrusive.Native.MVC5.1.2.0.nupkg
```

##Creating MVC 4 / MVC 3 packages

When creating the MVC 4 / MVC 3 packages you may want to amend the packages.config file with developmentDependency flags as follows:

```
  <package id="Microsoft.AspNet.Mvc" version="5.0.0" targetFramework="net45" developmentDependency="true" />
  <package id="Microsoft.AspNet.Razor" version="3.0.0" targetFramework="net45" developmentDependency="true" />
  <package id="Microsoft.AspNet.WebPages" version="3.0.0" targetFramework="net45" developmentDependency="true" />
  <package id="Microsoft.Web.Infrastructure" version="1.0.0.0" targetFramework="net45" developmentDependency="true" />
```

This will prevent you generating an MVC 4 / MVC 3 NuGet package which has a dependency on Microsoft.AspNet.Mvc >= version 5. 

Alternatively you could install the correct nuget packages for generation.



###To create the MVC 4 package:

-	Remove System.Web.Mvc and System.Web.WebPages references
-	Add System.Web.Mvc 4.0.0.0 reference
-	Add System.Web.WebPages 2.0.0.0 reference
-	Change nuspec id and title to jQuery.Validation.Unobtrusive.Native.MVC4 in jQuery.Validation.Unobtrusive.Native.nuspec
-	Compile in release mode

Then run the following commands to generate and publish based on project:

```
nuget pack jQuery.Validation.Unobtrusive.Native.csproj -Prop Configuration=Release
nuget push jQuery.Validation.Unobtrusive.Native.MVC4.1.1.1.0.nupkg
```


###To create the MVC 3 package:

-	Remove System.Web.Mvc and System.Web.WebPages references
-	Add System.Web.Mvc 3.0.0.0 reference
-	Add System.Web.WebPages 1.0.0.0 reference
-	In TextBoxExtensions.cs remove the format overload
-	Change nuspec id and title to jQuery.Validation.Unobtrusive.Native.MVC3 in jQuery.Validation.Unobtrusive.Native.nuspec
-	Compile in release mode

Then run the following commands to generate and publish based on project:

``` 
nuget pack jQuery.Validation.Unobtrusive.Native.csproj -Prop Configuration=Release
nuget push jQuery.Validation.Unobtrusive.Native.MVC3.1.1.1.0.nupkg
```