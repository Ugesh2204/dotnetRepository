$((function () {
    var url;
    var redirectUrl;
    var target;

    $('body').append(`


               
                    <div class="modal fade" id="deleteModal">
                      <div class="modal-dialog">
                        <div class="modal-content">

                          <!-- Modal Header -->
                          <div class="modal-header">
                            <h4 class="modal-title">Warning !</h4>
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                          </div>

                          <!-- Modal body -->
                          <div class="modal-body">
                            Are you sure you want to delete this item from your filesystem !
                          </div>

                          <!-- Modal footer -->
                          <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal" id="cancel-delete">Cancel</button>
                            <button type="button" class="btn btn-danger" id="confirm-delete">Delete</button>
                          </div>

                        </div>
                      </div>
                    </div>
             `);

    //Delete Action
    $(".delete").on('click', (e) => {
        //alert("test");
        e.preventDefault();

        target = e.target;
        var Id = $(target).data('id');
        var controller = $(target).data('controller');
        var action = $(target).data('action');
        var bodyMessage = $(target).data('body-message');
        redirectUrl = $(target).data('redirect-url');

        url = "/" + controller + "/" + action + "?Id=" + Id;
        $(".delete-modal-body").text(bodyMessage);
        $("#deleteModal").modal('show');
    });

    $("#confirm-delete").on('click', () => {

        //alert("test");
        $.get(url)
            .done((result) => {
                swal("Success", "Your pet has been removed!", "success");

                if (!redirectUrl) {
                    return $(target).parent().parent().hide("slow");
                }
                window.location.href = redirectUrl;
            })
            .fail((error) => {
                swal("Error", "Your pet could not be removed!", "error");

                if (redirectUrl)
                    window.location.href = redirectUrl;
            }).always(() => {
                $("#deleteModal").modal('hide');
            });
    });

}));
