$(document).ready(function () {
    jQuery.extend(jQuery.validator.messages, {
        required: "Este campo es obligatorio.",
        remote: "Por favor, rellena este campo.",
        email: "Por favor, escribe una dirección de correo válida",
        url: "Por favor, escribe una URL válida.",
        date: "Por favor, escribe una fecha válida.",
        dateISO: "Por favor, escribe una fecha (ISO) válida.",
        number: "Por favor, escribe un número entero válido.",
        digits: "Por favor, escribe sólo dígitos.",
        creditcard: "Por favor, escribe un número de tarjeta válido.",
        equalTo: "Por favor, escribe el mismo valor de nuevo.",
        accept: "Por favor, escribe un valor con una extensión aceptada.",
        maxlength: jQuery.validator.format("Por favor, no escribas más de {0} caracteres."),
        minlength: jQuery.validator.format("Por favor, no escribas menos de {0} caracteres."),
        rangelength: jQuery.validator.format("Por favor, escribe un valor entre {0} y {1} caracteres."),
        range: jQuery.validator.format("Por favor, escribe un valor entre {0} y {1}."),
        max: jQuery.validator.format("Por favor, escribe un valor menor o igual a {0}."),
        min: jQuery.validator.format("Por favor, escribe un valor mayor o igual a {0}.")
    });


    $("body").on('click', 'button', function () {
        if (typeof (CKEDITOR) !== 'undefined') {
                var descripcion = $('#descripcion_espanol').val(CKEDITOR.instances['descripcion_espanol'].getData());
        }

        if (typeof (CKEDITOR) !== 'undefined') {
            // coginedo los datos por ajax de CKEDITOR           
                var descripcion = $('#descripcion_ingles').val(CKEDITOR.instances['descripcion_ingles'].getData());
          
        }
          
        // Si el boton no tiene el atributo ajax no hacemos nada
        if ($(this).data('ajax') == undefined) return;

        // El metodo .data identifica la entrada y la castea al valor más correcto
        if ($(this).data('ajax') != true) return;

        var form = $(this).closest("form");
        var buttons = $("button", form);
        var button = $(this);
        var url = form.attr('action');

        if (button.data('confirm') != undefined)
        {
            if (button.data('confirm') == '') {
                if (!confirm('¿Esta seguro de realizar esta acción?')) return false;
            } else {
                if (!confirm(button.data('confirm'))) return false;
            }
        }

        if (button.data('delete') != undefined)
        {
            if (button.data('delete') == true)
            {
                url = button.data('url');
            }
        }else
        {
            if (!form.valid()) {
                return false;
            }
        }

        // Creamos un div que bloqueara todo el formulario
        var block = $('<div class="block-loading" />');
        form.prepend(block);

        // En caso de que haya habido un mensaje de alerta
        $(".alert", form).remove();

        // Para los formularios que tengan CKupdate
        if (form.hasClass('CKupdate')) CKupdate();


     
        form.ajaxSubmit({
            dataType: 'JSON',
            type: 'POST',
            url: url,
            success: function (r) {
                block.remove();
                if (r.response) {
                    if (!button.data('reset') != undefined) {
                        if (button.data('reset')) form.reset();
                    }
                    else
                    {
                        form.find('input:file').val('');
                    }
                }

                // Mostrar mensaje
                if (r.message != null) {
                    if (r.message.length > 0) {
                        var css = "";
                        if (r.response) css = "alert-success";
                        else css = "alert-danger";

                        var message = '<div class="col-sm-12"><div class="alert ' + css + ' alert-dismissable"><button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>' + r.message + '</div></div>';
                        form.prepend(message);
                    }
                }

                // Ejecutar funciones
                if (r.function != null) {
                    setTimeout(r.function, 0);
                }
                // Redireccionar
                if (r.href != null) {
                    if (r.href == 'self') window.location.reload(true);
                    else window.location.href = r.href;
                }
            },
            beforeSubmit: function (formData, jqForm, options) {
              //  console.log(JSON.parse(formData));
              //  debugger;
                var queryString = $.param(formData);
            },
            error: function(jqXHR, textStatus, errorThrown){
                block.remove();
                form.prepend('<div class="alert alert-warning alert-dismissable"><button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>' + errorThrown + ' | <b>' + textStatus + '</b></div>');
            }
        });

        return false;
    })

    //Plugins();
})
/*function Plugins()
{
    $(".datepicker").datepicker({
        dateFormat: 'dd/mm/yy',
        changeMonth: true,
        changeYear: true
    });
}
*/
jQuery.fn.reset = function () {
    $("input:password,input:file,input:text,textarea", $(this)).val('');
    $("input:checkbox:checked", $(this)).click();
    $("select").each(function () {
        $(this).val($("option:first", $(this)).val());
    })
};




function previsualizar() {
    var input = document.getElementById('foto');
    if (input.files[0] === undefined) {
    } else {
        var fReader = new FileReader();
        fReader.readAsDataURL(input.files[0]);
        fReader.onloadend = function (event) {
            var img = document.getElementById("imgMostrar");
            img.src = event.target.result;
        }
    }
}





