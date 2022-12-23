$(document).ready(function () {
    var mode = "light";


    $('#mode').click(function () {
        if (mode === "light") {
            mode = "dark";
            document.getElementsByClassName('.table').style.backgroundColor = "white";
            $('.table').style.color = "#2c2c2c";
            console.log("asdadad")
        }
    });
});

