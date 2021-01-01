var connection = null;

$(function () {
    //1.check for connection then go and bulit a connection to signalR
    if (connection == null) {
        connection = new signalR.HubConnectionBuilder()
            .withUrl("/notificationHub")
            .build();

        //Set somme events check your chat your to know the evemt
        //Event are Broadcast,UserConnected,UserDisconnected



        connection.on("Broadcast", function (response) {
            $("#notificationMessage").append(

                //"<li>" + response.messageBody + "</li>"

                '<div class="notification-item" >' +
                '<h4 class="item-title">GymPro Fitness</h4 >' +
                '<p class="item-info">'+ response.messageBody +'</p>'+
                 '</div >'

            );

        });


       

        //alerting error msg

        connection.on("HubError", function (response) {

            alert(response.error);

        });

        //connction start which listen in any msg from user
        //and ivok a method BroadcastFromClient from Chathub
        connection.start().then(function () {

            document.getElementById('sendButton').onclick = function () {
                //here is the msg the user is typing and we grab the value of the msg
                var message = document.getElementById("messageInput").value;

                //we need to talk to signalr we need a connection
                connection.invoke("BroadcastFromClientOne", message)
                    .catch(function (err) {
                        return console.error(err.toString());
                    });
            }

        });

    }


});