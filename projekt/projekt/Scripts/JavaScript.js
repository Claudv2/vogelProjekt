$(document).ready(function () {

    if (!sessionStorage.getItem('mode')) {
        sessionStorage.setItem('mode', 'light')
    }

    console.log('asdasdasd')
    $('#modeButton').click(function () { 
        if (sessionStorage.getItem('mode') === "light") {
            sessionStorage.setItem('mode', 'dark')
        }
        else {
            sessionStorage.setItem('mode', 'light')
        }
        getColor()
    });

    getColor();

    function getColor() {
        if (sessionStorage.getItem('mode') === "dark") {
            document.body.style.backgroundColor = "#2c2c2c";
            document.body.style.color = "white";
            document.getElementById('modeButton').style.color = "#2c2c2c"
            document.getElementById('addButton').style.color = "#2c2c2c"
        }
        else if (sessionStorage.getItem('mode') === "light") {
            document.body.style.backgroundColor = "white";
            document.body.style.color = "#2c2c2c";
            document.getElementById('modeButton').style.color = "#2c2c2c"
            document.getElementById('addButton').style.color = "#2c2c2c"
        }
    }
});

    

