$(document).ready(function () {
    $.ajax({
        url: 'https://localhost:44364/api/Employees/GetEmployees',
        dataType: "json",
        type: "GET",
        headers: { "Authorization": 'Bearer '+sessionStorage.getItem('token') },
        contentType: "application/json",
        success: function (data, textStatus, error) {
            console.log(data);
            if (data) {
                let code = ""
                for (let x in data) {
                    code += "<tr>"
                    code += "<td>" + data[x].employee_id + "</td>"
                    code += "<td>" + data[x].employee_name + "</td>"
                    code += "<td> <span class='badge badge-secondary'>" + data[x].skills + "</span></td>"
                    code += "<td>" + data[x].profilename+ "</td>"
                    code += "<td>" + data[x].experience + "</td>"
                    code += "<td>" + data[x].manager + "</td>"
                    code += "<td> <button class='btn btn-primary' onclick='Request(" + data[x].employee_id + ")'> Request Lock </button> </td>"
                    code += "</tr>"
                }
                $("#tdata").html(code)
            }
        },
        error: function (error, textStatus, errorThrown) {
            alert(error.responseJSON.message)
        }
    });
});

function Request(id) {
    $('#employeeid').text("Please confirm the lock request for " + id + "");
    $('#empid').val(id);
    $('#Modal').modal('show');
}

function Lockrequest() {
    var empid = $('#empid').val();
    var reqmessage = $('#request').val();
    $.ajax({
        url: 'https://localhost:44364/api/Softlocks/InsertSoftlocks',
        dataType: "json",
        type: "POST",
        headers: { "Authorization": 'Bearer ' + sessionStorage.getItem('token') },
        data: JSON.stringify({
            employee_id: empid,
            requestmessage: reqmessage
        }),
        contentType: "application/json",
        success: function (data, textStatus, jQxhr) {
            updateemployee(empid);
        },
        error: function (error, textStatus, errorThrown) {
            console.log(error);
            alert("Error occured while inserting")
        }
    });
}

function updateemployee(id) {
    $.ajax({
        url: 'https://localhost:44364/api/Employees/UpdateEmployees',
        dataType: "json",
        type: "PUT",
        headers: { "Authorization": 'Bearer ' + sessionStorage.getItem('token') },
        data: JSON.stringify({
            employee_id: id,
            lockstatus: "request _waiting"
        }),
        contentType: "application/json",
        success: function (data, textStatus, jQxhr) {
            alert("Updated Successfully");
            window.location.replace('Manager')
        },
        error: function (error, textStatus, errorThrown) {
            console.log(error);
            alert("Error occured while updating");
        }
    });
    $('#Modal').modal('hide');
    $('#request').val('');
}
