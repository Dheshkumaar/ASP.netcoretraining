$(document).ready(function () {
    console.log('submit');
    $('#submit').click(function () {

        var Username = $("#username").val();
        var Password = $("#pwd").val();

        if (Username == '')
            $("#user").addClass("d-block");
        else
            $("#user").removeClass("d-block");

        if (Password == '')
            $("#password").addClass("d-block");
        else
            $("#password").removeClass("d-block");

        if (Username != "" && Password != "") {

            $.ajax({
                url: 'https://localhost:44364/api/Users/authenticate',
                dataType: "json",
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify({
                    username: Username,
                    password: Password
                }),
                success: function (data, textStatus, error) {
                    alert("User successfully authenticated")
                    sessionStorage.setItem("token", data.token);
                    if (data.role == "manager") {
                        window.location.replace('Manager')
                    }
                    else {
                        window.location.replace('WfmMember')
                    }
                },
                error: function (error, textStatus, errorThrown) {
                    alert(error.responseJSON.message)
                }
            });
        }
    });
});