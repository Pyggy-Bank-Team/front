var styles = ["mobile", "720", "960", "1200"];

function onResize(i, width){

    var style = styles[i];

    switch(style){
        case "mobile":
            setMobileStyles();
            break;
        case "720":
            set720Styles();
            break;
        case "960":
            set960Styles();
            break;
        case "1200":
            set1200Styles();
            break;
    }
}

function setMobileStyles(){

    document.getElementById("f-contiener").className = "footer-mobile";
    document.getElementById("f-email").className = "f-email-mobile";
    document.getElementById("f-logo").className = "f-logo-moblie";
    document.getElementById("f-app-name").className = "f-app-name-mobile";
}

function set720Styles(){

    document.getElementById("f-contiener").className = "footer";
    document.getElementById("f-email").className = "f-email-720";
    document.getElementById("f-logo").className = "f-logo-720";
    document.getElementById("f-app-name").className = "f-app-name-720";
}

function set960Styles(){

    document.getElementById("f-contiener").className = "footer";
    document.getElementById("f-email").className = "f-email-960";
    document.getElementById("f-logo").className = "f-logo-960";
    document.getElementById("f-app-name").className = "f-app-name-960";
}

function set1200Styles(){

    document.getElementById("f-contiener").className = "footer";
    document.getElementById("f-email").className = "f-email-1200";
    document.getElementById("f-logo").className = "f-logo-1200";
    document.getElementById("f-app-name").className = "f-app-name-1200";
}
