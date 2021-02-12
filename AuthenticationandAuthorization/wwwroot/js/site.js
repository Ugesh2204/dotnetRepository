//short form document.ready() function
$(function () {
    $('[data-toggle="tooltip"]').tooltip()


//function get Notification Ajax call

    function getNotification() {
        $.ajax({
            url: "/Notification/GetNotification",
            method: "GET",
            success: function (result) {
                $("#notificationCount").html(result.count);

                console.log(result);
            },
            error: function (error) {
                console.log(error);
            }
        });

    }

    getNotification();
})