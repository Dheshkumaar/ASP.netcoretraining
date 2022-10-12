$(document).ready(function () {
    $.ajax({
        url: 'https://localhost:44364/api/Softlocks/GetAllSoftlocks',
        dataType: "json",
        type: "GET",
        headers: { "Authorization": 'Bearer ' + sessionStorage.getItem('token') },
        contentType: "application/json",
        success: function (data, textStatus, error) {
            console.log(data);
            if (data) {
                let code = "";

                for (let x in data) {
                    const d = new Date(data[x].reqdate)
                    code += "<tr>"
                    code += "<td>" + data[x].employee_id + "</td>"
                    code += "<td>" + data[x].manager + "</td>"
                    code += "<td>" + d.toDateString() + "</td>"
                    code += "<td>" + data[x].requestmessage + "</td>"
                    code += "<td> <button class='btn btn-primary' onclick = 'ViewDetails(" + data[x].lockid + ")'> View Details </button> </td> </tr>"
                }
                $('#tdata').html(code)
            }
        },
        error: function (error, textStatus, errorThrown) {
            alert(error.responseJSON.message)
        }
    });
});

function ViewDetails(lockid) {
    $.ajax({
        url: 'https://localhost:44364/api/Softlocks/GetSoftLocksById?lockid=' + lockid,
        dataType: "json",
        type: "GET",
        headers: { "Authorization": 'Bearer ' + sessionStorage.getItem('token') },
        contentType: "application/json",
        success: function (data, textStatus, error) {
            console.log(data);
            if (data != null) {
                $("#lockid").val(data.lockid);
                $("#empid").val(data.employee_id);
                $('#employee_id').text(data.employee_id);
                $('#manager').text(data.manager);
                $('#requestmessage').text(data.requestmessage);
                $('#Modal').modal('show');
            }
        },
        error: function (error, textStatus, errorThrown) {
            alert(error.responseJSON.message)
        }
    });
}

function updaterequest() {
    var empid = $("#empid").val();
    var lockid = $("#lockid").val();
    var status = $('#managerstatus option:selected').val();
    $.ajax({
        url: 'https://localhost:44364/api/Softlocks/UpdateSoftlocks',
        dataType: "json",
        type: "PUT",
        headers: { "Authorization": 'Bearer ' + sessionStorage.getItem('token') },
        data: JSON.stringify({
            lockid: lockid,
            managerstatus: status
        }),
        contentType: "application/json",
        success: function (data, textStatus, jQxhr) {
            updateemployee(empid, status);
        },
        error: function (error, textStatus, errorThrown) {
            console.log(error);
            alert("Error occured while inserting")
        }
    });
}

function updateemployee(empid, status) {
    var empstatus;
    if (status == "accepted") {
        empstatus = "locked";
    }
    else {
        empstatus = "not_requested";
    }
    $.ajax({
        url: 'https://localhost:44364/api/Employees/UpdateEmployees',
        dataType: "json",
        type: "PUT",
        headers: { "Authorization": 'Bearer ' + sessionStorage.getItem('token') },
        data: JSON.stringify({
            employee_id: empid,
            lockstatus: empstatus
        }),
        contentType: "application/json",
        success: function (data, textStatus, jQxhr) {
            alert("Updated Successfully");
            window.location.replace('WfmMember');
        },
        error: function (error, textStatus, errorThrown) {
            console.log(error);
            alert("Error occured while inserting")
        }
    });
    $('#Modal').modal('hide');
}