var connection = null;

$(function (){
    //1.check for connection then go and bulit a connection to signalR
    if (connection == null) {
        connection = new signalR.HubConnectionBuilder()
            .withUrl("/chatHub")
            .build();

        //Set somme events check your chat your to know the evemt
        //Event are Broadcast,UserConnected,UserDisconnected



        connection.on("Broadcast", function (response) {
            //as soon a client type a msg it should append a new div element
            // to the chat box
            //we get a whole msg amd who that msg is from. we can mainuplate the thml
            // response.messageBody is sent from the chat hub

            $("#chatRoom").append(
                '<div class="media w-50 ml-auto mb-3">' +
                '<img src="https://img.icons8.com/officel/16/000000/user.png" alt="user" width="50" class="rounded-circle">' +
                '<div class="media-body">' +
                '<div class="bg-primary rounded py-2 px-3 mb-2">' +
                '<p class="text-small mb-0 text-white">' + response.messageBody + '</p>' +
                '</div>' +
                '<p class="small text-muted">' + response.fromUser + '</p>' +
                '<p class="small text-muted">' + response.messageDtTm + '</p>' +
                '</div>' +
                '</div>'
            );

            //scroll bar
            $('#chatRoom').stop().animate({
                scrollTop: $('#chatRoom')[0].scrollHeight
            });
            
        });


        connection.on("UserConnected", function (response) {

            //so when the users is connect we want to do 2 things
            //we want to add that use to a list of connected users
            //suppose an admin user sent a msg to everyone saying
            //-> hey WELCOME TO THE CHAT ROOM
            //Remeber signalr have a unique connection id
            //COULD DO SOMETHING WITH THIS TO NOTIFY admin 


            $("#chatUsers").append(
                '<a class="list-group-item list-group-item-action active text-white rounded-0">' +
                '<div class= "media">' +
                '<img src="https://img.icons8.com/officel/16/000000/user.png" alt="user" width="50" class="rounded-circle">' +
                '<div class="media-body ml-4">' +
                '<div class="d-flex align-items-center justify-content-between mb-1">' +
                '<h6 class="mb-0">User</h6><small class="small font-weight-bold">' + response.connectionDtTm + '</small>' +
                '</div>' +
                '<p class="font-italic mb-0 text-small">' + response.connectionId + '</p>' +
                '</div>' +
                '</div>' +
                '</a>'
            );


            //Admin user send message to all user in the chat room
            $("#chatRoom").append(
                '<div class="media w-50 mb-3">' +
                '<img src="https://img.icons8.com/dusk/64/000000/user-female-skin-type-1-2.png" alt="user" width="50" class="rounded-circle">' +
                '<div class="media-body ml-3">' +
                '<div class="bg-light rounded py-2 px-3 mb-2">' +
                '<p class="text-small mb-0 text-muted">Welcome to the Chat Room!</p>' +
                '</div>' +
                '<p class="small text-muted">' + response.messageDtTm + '</p>' +
                '</div>'
            );

        });


        connection.on("UserDisconnected", function (message) {
            alert(message);
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
                connection.invoke("BroadcastFromClient", message)
                    .catch(function (err) {
                        return console.error(err.toString());
                    });
            }

        });

    }


});