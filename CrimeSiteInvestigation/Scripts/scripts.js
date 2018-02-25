
$(document).ready(function () {

    $('.carousel').carousel({ interval: false });

    $('#BotaoResolver').click(function () {
        var suspeito = $("#myCarousel1").find(".active").index();
        var local = $("#myCarousel2").find(".active").index();
        var arma = $("#myCarousel3").find(".active").index();

        $.ajax({
            url: "/Home/TentarResolver",
            dataType: "json",
            type: "Get",
            data: { suspeito, local, arma },
            success: function (data) {

                if (data.Success) {

                    $("#suspeito").html($("#myCarousel1").find(".active").find("div").html());
                    $("#local").html($("#myCarousel2").find(".active").find("div").html());
                    $("#arma").html($("#myCarousel3").find(".active").find("div").html());
                    $("#cartao").html(data.Tentativa);

                    if (data.Tentativa == 0) {
                        $(".venceu").show();
                        $("#tentarnovamente").hide();
                    } else {
                        $("#tentarnovamente").show();
                        $(".venceu").hide();
                    }

                    $("#result").show();
                }
            },
            error: function (xhr) {
                alert('error');
            }
        });

    });
});