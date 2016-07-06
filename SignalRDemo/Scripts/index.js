$(function() {
    var simpleHub = $.connection.simpleHub;
    $.connection.hub.start();

    simpleHub.client.newMessageReceived = function(message) {
        $("ul").append("<li>" + message.foo + "</li>");
    }

    $("#sendit").on('click', function() {
        $.post('/home/newmessage', { text: $("#textbox").val() });
    });
});