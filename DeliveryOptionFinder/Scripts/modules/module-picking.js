

function fetch(code) {
 
    var url = "/Home/details/" + code;
    $.getJSON(url).done(function (data) {
        console.log(data);
        console.log(data[0]);
        $("#delAvailable").html(data[0].DeliveryAvailable);
     
    });
}

function resetViewer() {
    $("#delAvailable").html("");
   
}