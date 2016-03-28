jQuery Validation Unobtrusive Native [![Build Status](https://ci.appveyor.com/api/projects/status/github/johnnyreilly/jQuery.Validation.Unobtrusive.Native?retina=true)](https://ci.appveyor.com/project/JohnReilly/jquery-validation-unobtrusive-native)
====================================

jQuery.Validation.Unobtrusive.Native is a collection of ASP.Net MVC HTML helper extensions that make use of jQuery Validation's native unobtrusive support for validation driven by HTML 5 data attributes.  Microsoft shipped [jquery.validate.unobtrusive.js](http://bradwilson.typepad.com/blog/2010/10/mvc3-unobtrusive-validation.html) back with MVC 3.  It provided a way to apply data model validations to the client side using a combination of jQuery Validation and HTML 5 data attributes (that's the "unobtrusive" part).

The principal of this was and is fantastic.  But since that time the jQuery Validation project has implemented its own support for driving validation unobtrusively (this shipped with [jQuery Validation 1.11.0](http://jquery.bassistance.de/validate/changelog.txt)).  The advantages of the native support over jquery.validate.unobtrusive.js are:

* Dynamically created form elements are parsed automatically.  jquery.validate.unobtrusive.js does not support this.
* jquery.validate.unobtrusive.js restricts how you use jQuery Validation.  Want to use showErrors etc?  Well you'll need to go native... 
* Send less code to your browser, make your browser to do less work, get a performance benefit (though you'd probably have to be the Flash to actually notice the difference)

This project intends to be a bridge between MVC's inbuilt support for driving validation from data attributes and jQuery Validation's native support for the same.  This is achieved by hooking into the MVC data attribute creation mechanism and using it to generate the data attributes used by jQuery Validation.

You can see more detail on the [demo site](http://johnnyreilly.github.io/jQuery.Validation.Unobtrusive.Native/).

##Getting started

If you haven't already, ensure that the following entries can be found in your web.config:

    <appSettings>
        <add key="ClientValidationEnabled" value="true" />
        <add key="UnobtrusiveJavaScriptEnabled" value="true" />
    </appSettings>

Include jQuery.Validation.Unobtrusive.Native into your project (available on [nuget](http://www.nuget.org/packages?q=jQuery.Validation.Unobtrusive.Native) or on [GitHub](http://github.com/johnnyreilly/jQuery.Validation.Unobtrusive.Native)). With this in place you should be able to switch from using the existing `TextBoxFor` / `DropDownListFor` / `CheckBoxFor` / `TextAreaFor` / `RadioButtonFor` / `ListBoxFor` / `PasswordFor` HtmlHelper statements in your views and to jQuery.Validation.Unobtrusive.Native's equivalent by passing `true` to the `useNativeUnobtrusiveAttributes` parameter. (By convention this is the first parameter after the `Expression<Func<TModel, TProperty>> expression` parameter.
	
Ensure that you have the latest version of jquery.validate.js, you can find it [here](http://jqueryvalidation.org/).  Oh, and remember that you *no longer* need to serve up the jquery.validate.unobtrusive.js on a screen where you are using jQuery.Validation.Unobtrusive.Native.  All you need is jquery.validate.js (and of course jQuery).

P.S. If you're using the source code from GitHub in Visual Studio, make sure you have the Package Manager option *"Allow NuGet to download missing packages during build"* set to true.  This will ensure that the required packages are downloaded from NuGet.

##Examples

Where you would previously have written:

    @Html.TextBoxFor(x => x.RangeAndNumberDemo)

To use jQuery.Validation.Unobtrusive.Native you would put:

    @Html.TextBoxFor(x => x.RangeAndNumberDemo, true)

Or, where you would have written:

    @Html.DropDownListFor(x => x.DropDownRequiredDemo, new List<SelectListItem> {
        new SelectListItem{ Text = "Please select", Value = "" },
        new SelectListItem{ Text = "An option", Value = "An option"}
    })

Now you would put:

    @Html.DropDownListFor(x => x.DropDownRequiredDemo, true, new List<SelectListItem> {
        new SelectListItem{ Text = "Please select", Value = "" },
        new SelectListItem{ Text = "An option", Value = "An option"}
    })

The only differences above are the extra `true` parameters being passed.  If you had passed `false` instead jQuery.Validation.Unobtrusive.Native internally calls the inbuilt MVC implementation.  I have considered keeping jQuery.Validation.Unobtrusive.Native's HtmlHelpers entirely separate from the inbuilt MVC ones and instead implementing `TextBoxNativeFor` / `DropDownListNativeFor` etc... methods which share the same signatures as the inbuilt MVC ones.  For now this is the way it is but it could change if people feel strongly enough - if you've an opinion then drop me a line with your rationale.

By the way, the above examples (and others) can be found in the MVC demo project jVUNDemo on GitHub - this demo site be viewed at [johnnyreilly.github.io/jQuery.Validation.Unobtrusive.Native/](http://johnnyreilly.github.io/jQuery.Validation.Unobtrusive.Native/).  2 of the demos ([Remote](http://johnnyreilly.github.io/jQuery.Validation.Unobtrusive.Native/Demo/Remote.html) and [Globalize](http://johnnyreilly.github.io/jQuery.Validation.Unobtrusive.Native/AdvancedDemo/Globalize.html)) do not work completely as static sites (which GitHub pages are).  If you would like to see these demo's in action it's best you run the jVUNDemo project locally.

## State of the Union

This is basically a "done" project. Work is complete and I'm not aware of any missing pieces.  I could port this to ASP.Net Core / MVC 6 when it ships but I don't have any immediate plans to.  Never say never though.

## Author
**John Reilly**

+ http://twitter.com/johnny_reilly

## Credits
Inspired by jquery.validate.unobtrusive.js and entirely dependent on http://github.com/jzaefferer/jquery-validation and http://aspnet.codeplex.com/wikipage?title=MVC.

## Copyright
Copyright © 2013 [John Reilly](mailto:johnny_reilly@hotmail.com).

##License

MIT license - [http://www.opensource.org/licenses/mit-license.php](http://www.opensource.org/licenses/mit-license.php)

##Changelog

### 1.3.0 / 2015-11-27

- [Added EnumDropDownListFor support for MVC 5.1](https://github.com/johnnyreilly/jQuery.Validation.Unobtrusive.Native/issues/23) (thanks to thanks to Ryan Kenney)

### 1.2.0 / 2015-06-08

- [Added support for RegularExpression, MaxLength, MinLength and FileExtensions attributes](https://github.com/johnnyreilly/jQuery.Validation.Unobtrusive.Native/pull/17) (thanks to [Ben Duguid](https://github.com/Zhaph) for this)

### 1.1.2 / 2015-01-07

- [Moved from System.Web.Mvc namespace to System.Web.Mvc.Html in line with MVC's built in extension methods](https://github.com/johnnyreilly/jQuery.Validation.Unobtrusive.Native/issues/12)

### 1.1.1 / 2014-05-27

- [Bugfix for CheckBoxFor.](https://github.com/johnnyreilly/jQuery.Validation.Unobtrusive.Native/issues/9)

### 1.1.0.0 / 2013-10-04

- Added support for PasswordFor, previously missing.

### 1.0.0.0 / 2013-09-04

- Fix to allow usage of EditorTemplates (thanks to @DavidCarroll for this)
- Fix to make range culture invariant to enable use by cultures where the decimal place is represented by something other than a decimal place (eg in Germany 20.5 is expressed as 20,5 - JavaScript can't handle this yet).
- Given major version number now that the rough edges have been dealt with.

### 0.4.1.0 / 2013-08-25

- Now possible to override generated data attributes with those passed in htmlAttributes parameter.

### 0.4.0.0 / 2013-08-14

- All missing helpers now covered (TextArea / ListBox etc)
- Switch to new mechanism to support users implementing their own custom validations
- Included demo of custom validations implementation

### 0.2.0 / 2013-08-07

- Initial release
- Included demo of dynamic content using Knockout.

### 0.1.0 / 2013-07-29

- Beta release - not fully featured
