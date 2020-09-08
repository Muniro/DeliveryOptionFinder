

function fetch(code) {
 
    var url = "/Home/details/" + code;
    $.getJSON(url).done(function (data) {
        $("#delAvailable").html(data[0].DeliveryAvailable);
     
    });
}

function resetViewer() {
    $("#delAvailable").html("");
   
}