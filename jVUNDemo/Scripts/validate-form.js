var $form = $("form");
$form.validate({

    errorPlacement: function($errorLabel, $element) {

        var $elementToInsertAfter = $element;
        if ($element.prop("type") === "radio") {
            $elementToInsertAfter = $element.closest(".row");

            $errorLabel.appendTo($elementToInsertAfter);
        } else {
            $errorLabel.insertAfter($elementToInsertAfter);
        }
    },

    submitHandler: function (form) {
        alert("This is a valid form!");
    }
});
