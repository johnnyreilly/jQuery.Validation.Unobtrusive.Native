/*!
** An extension to the jQuery Validation Plugin which makes it use Globalize.js for number and date parsing 
** Copyright (c) 2013 John Reilly
*/

(function ($, Globalize) {

    // Tell the validator that we want numbers parsed using Globalize

    $.validator.methods.number = function (value, element) {
        var val = Globalize.parseFloat(value);
        return this.optional(element) || ($.isNumeric(val));
    };

    $.validator.methods.min = function (value, element, param) {
        var val = Globalize.parseFloat(value);
        return this.optional(element) || val >= param;
    };

    $.validator.methods.max = function (value, element, param) {
        var val = Globalize.parseFloat(value);
        return this.optional(element) || val <= param;
    };

    $.validator.methods.range = function (value, element, param) {
        var val = Globalize.parseFloat(value);
        return this.optional(element) || (val >= param[0] && val <= param[1]);
    };

    // Tell the validator that we want dates parsed using Globalize

    $.validator.methods.date = function (value, element) {
        var val = Globalize.parseDate(value);
        return this.optional(element) || (val);
    };

}( jQuery, Globalize ));