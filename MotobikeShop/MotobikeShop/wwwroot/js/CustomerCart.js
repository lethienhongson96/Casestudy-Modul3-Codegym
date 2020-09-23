var CustomerCart = CustomerCart || {};

CustomerCart.AddItem = function (id) {

    var amount = $(`#${id}`).val();
    //var UserId = $("#UserId").val();
    $.ajax({
        url: `/Cart/AddItem/${id}/${amount}`,
        method: "GET",
        contentType: 'json',
        success: function (data) {
            console.log(data);

            if (data == -1) {
                bootbox.alert("<p style='color: green'>Thêm Sản Phẩm Thành Công</p>");
            }
            else {
                bootbox.alert("<p style='color: green'>Thêm Sản Phẩm Thành Công</p>");
                $("#CartNum").html(parseInt($("#CartNum").text(), 10) + parseInt(1, 10));
            }
        }
    });
}


CustomerCart.OrderByAccount = function (id) {
    $.ajax({
        url: `/Cart/OrderByAccount/${id}`,
        method: "GET",
        contentType: 'json',
        success: function (data) {
            console.log(data);
            if (data > 0) {
                bootbox.alert({
                    message: "<p style='color: green'>Đặt Hàng Thành Công, Xin Cảm Ơn !</p>",
                    callback: function () {
                        window.location.href = "/CustomerHome/Index/";
                    }
                });
            }
        }
    });
}

CustomerCart.RemoveItem = function (id) {
    $.ajax({
        url: `/Cart/RemoveItem/${id}`,
        method: "GET",
        contentType: 'json',
        success: function (data) {
            console.log(data);
            if (data > 0) {
                window.location.href = "/CustomerHome/WatchCart/";
            }
        }
    });
}

$('#exampleModal').on('show.bs.modal', function (event) {
    var button = $(event.relatedTarget) // Button that triggered the modal
    var recipient = button.data('whatever') // Extract info from data-* attributes
    // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
    $("#Submit").click(function () {

        var name = $("#Name").val();
        var phoneNum = $("#PhoneNum").val();
        var email = $("#Email").val();
        var address = $("#Address").val();

        $.ajax({
            url: `/Cart/OrderWithoutAccount/${name}/${phoneNum}/${email}/${address}`,
            method: "GET",
            contentType: 'json',
            success: function (data) {
                console.log(data);
                if (data > 0) {
                    bootbox.alert({
                        message: "<p style='color: green'>Đặt Hàng Thành Công, Xin Cảm Ơn !</p>",
                        callback: function () {
                            window.location.href = "/CustomerHome/Index/";
                        }
                    });
                }
            }
        });
    })
    // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
    var modal = $(this)
    modal.find('.modal-title').text('New message to ' + recipient)
    modal.find('.modal-body input').val(recipient)
})



