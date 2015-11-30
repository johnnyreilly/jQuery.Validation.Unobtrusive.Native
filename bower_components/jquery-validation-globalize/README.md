jQuery Validation Globalize
===========================

[![Build Status](https://travis-ci.org/johnnyreilly/jquery-validation-globalize.svg?branch=master)](https://travis-ci.org/johnnyreilly/jquery-validation-globalize)

An extension to the jQuery Validation Plugin which makes it use Globalize for number and date parsing (enabling simple internationalized validation).

This extension has the following dependencies:
- [jQuery Validation](https://github.com/jzaefferer/jquery-validation) (which itself depends on jQuery) - any version to my knowledge
- [Globalize](https://github.com/jquery/globalize) v1.x

## Getting started

Simply include jquery.validate.globalize.js on a page **after** jquery-validate and globalize (you need the core, number and date globalize modules as well as their associated cldr data - see [here](http://johnnyreilly.github.io/globalize-so-what-cha-want/) for details).  Now you are validating using Globalize to do your number and date parsing.  Lucky you!

So what's different?  Well, for example, if you're catering for German users then you will be presumably using the "de-DE" Globalize culture.  If this culture has been selected at the time of validation then "27.08.2013" will be successfully validated as a date and "10,5" will be successfully validated as a number.

The following validator methods are patched by jQuery Validation Globalize:

- number
- min
- max
- range
- date

## Customisation

If you want to customise the data parsing you can do it by amending this to the parsing mechanism you prefer.  This is the default:

```
$.validator.methods.dateGlobalizeOptions = { dateParseFormat: { skeleton: "yMd" } };
```

[This](https://github.com/jquery/globalize/blob/master/doc/api/date/date-formatter.md) is a good resource for learning about parsing.  At present this only supports a single parsing format.  Changes could be made to support multiple formats if that was necessary.

## To install and test locally

```
npm install
npm run bower-install
npm run make-globalize-cldr-data-js
npm run test
```

## Install into your project

Using Bower: `bower install jquery-validation-globalize --save`  

## Author
**John Reilly**

+ http://twitter.com/johnny_reilly

## Credits
Inspired by [Scott Hanselman's blog post](http://www.hanselman.com/blog/GlobalizationInternationalizationAndLocalizationInASPNETMVC3JavaScriptAndJQueryPart1.aspx) and evolved from [my blog post](http://icanmakethiswork.blogspot.com/2012/09/globalize-and-jquery-validate.html).  Entirely dependent upon [jQuery Validation](https://github.com/jzaefferer/jquery-validation) and [Globalize](https://github.com/jquery/globalize/).

## Copyright
Copyright © 2013- [John Reilly](mailto:johnny_reilly@hotmail.com).

## License

MIT license - [http://www.opensource.org/licenses/mit-license.php](http://www.opensource.org/licenses/mit-license.php)

## Changelog

### 1.0.0 / 2015-09-27

- Moved to use Globalize 1.x.

### 0.1.1 / 2013-09-28

- Changed min, max and range to defer to original validation methods in jQuery Validation once parsing has taken place. Should the implementations of these ever change then we no longer need to propogate those changes manually into jQuery Validation Globalize.  
- Removed direct dependency on jQuery - not needed as jQuery Validation has (and will always have) this dependency itself.

### 0.0.1 / 2013-08-27

- Initial release
