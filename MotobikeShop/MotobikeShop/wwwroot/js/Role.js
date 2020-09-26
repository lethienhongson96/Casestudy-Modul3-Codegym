var Role = Role || {};

Role.Rename = function (id) {
    bootbox.prompt({
        title: "<p style='green'>Nhập tên Role Mới !</p>",
        centerVertical: true,
        callback: function (result) {
            console.log(result);

            $.ajax({
                url: `/Role/Edit/${id}/${result}`,
                method: "GET",
                contentType: 'json',
                success: function (data) {
                    console.log(data);
                    if (data.isSuccess) {
                        window.location.href = "/Role/Index/";
                    }
                }
            });
        }
    });
};

