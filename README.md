jQuery Validate Native Unobtrusive MVC
======================================

jQueryValidateNativeUnobtrusiveMVC is a collection of HTML helper extensions that make use of jQuery Validation's native unobtrusive support for validation driven by HTML 5 data attributes.  Microsoft shipped [jquery.validate.unobtrusive.js](http://bradwilson.typepad.com/blog/2010/10/mvc3-unobtrusive-validation.html) back with MVC 3.  It provided a way to apply data model validations to the client side using a combination of jQuery Validation and HTML 5 data attributes (that's the "unobtrusive" part).

The principal of this was and is fantastic.  But since that time the jQuery Validation project has implemented its own support for driving validation unobtrusively.  The advantages of the native support over jquery.validate.unobtrusive.js are:

* Dynamically created form elements are parsed automatically.  jquery.validate.unobtrusive.js does not support this.
* jquery.validate.unobtrusive.js restricts how you use jQuery Validation.  Want to use showErrors etc?  Well you'll need to go native... 
* Send less code to your browser, make your browser to do less work, get a performance benefit (though you'd probably have to be the Flash to actually notice the difference)

This project intends to be a bridge between MVC's inbuilt support for driving validation from data attributes and jQuery Validation's native support for the same.  This is achieved by mapping the data attributes created by MVC over to the data attributes used by jQuery Validation.

##Getting started

If you haven't already, ensure that the following entries can be found in your web.config:

    <appSettings>
        <add key="ClientValidationEnabled" value="true" />
        <add key="UnobtrusiveJavaScriptEnabled" value="true" />
    </appSettings>

Include jQueryValidateNativeUnobtrusiveMVC in your project and you should be able switch to using this by taking an existing HtmlHelper statement and passing `true` to the `useNativeUnobtrusiveAttributes` parameter. (By convention this is the first parameter after the `Expression<Func<TModel, TProperty>> expression` parameter.

Ensure that you have the latest version of jquery.validate.js, you can find it [here](http://jqueryvalidation.org/).  Oh, and remember that you no longer need to use jquery.validate.unobtrusive.js if you're using jQueryValidateNativeUnobtrusiveMVC.

##Plans

At the moment only a small subset of the HtmlHelpers and their associated unobtrusive mappings have been implemented, essentially driven by my own needs.  As I use more I will add more - and feel free to pitch in!

##License

MIT license - [http://www.opensource.org/licenses/mit-license.php](http://www.opensource.org/licenses/mit-license.php)
