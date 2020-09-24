var Role = Role || {};

Role.delete = function (id) {
    bootbox.confirm({
        title: "Warning",
        message: "are you sure?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> No'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Yes'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `/Role/Delete/${id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data.deleteResult) {
                            window.location.href = "/Role/Index/";
                        }
                    }
                });
            }
        }
    });
}

$(document).ready(function () {
    $("#IndexRole").dataTable(
        {
            "columnDefs": [
                {
                    "targets": 2,
                    "orderable": false,
                    "searchable": false
                }
            ]
        }
    );
});

