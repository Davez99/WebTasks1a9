var Objetousuario = new Object();

$(function () {
    $('#enviar').click(
        function () {
            Objetousuario.Salvarusuario();
        }
    );

});

Objetousuario.Salvarusuario = function () {
    var entrada = $('#entrada').val();

    var strUrl = "/api/ParImpar"

    $.ajax({

        type: "POST",
        url: strUrl,
        data: { entrada: entrada},
        dataType: "JSON",
        success: function (data) {
            $('#resultado').empty();
            data.forEach(function (entry) {
                $('#resultado').append(entry);
            });

        }

    });
}