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

    document.getElementById("b-mail-text").className = "b-mail-text-mobile";
    document.getElementById("b-follow-text").className = "b-contact-text-mobile";
    document.getElementById("b-question-text").className = "b-contact-text-mobile";
    document.getElementById('b-log-winstore').className = "b-log-winstore-mobile";
    document.getElementById("b-img-appstore").className = "b-img-appstore-mobile";
    document.getElementById("b-img-winstore").className = "b-img-winstore-mobile";
    document.getElementById("b-app-links-container").className = "b-app-links-container-mobile";
    document.getElementById("app-links-cont").className = "b-links-cont-mobile";
    document.getElementById("b-main-text").className = "b-main-text-mobile";

    document.getElementById("b-main-img-container-2").className = "";
    document.getElementById("b-main-img-container").className = "hidden";
    document.getElementById("clouds").className = "hidden";  

    document.getElementById("h-language-butt-content").className = "h-language-butt-content-mobile";
}

function set720Styles(){

    document.getElementById("f-contiener").className = "footer";
    document.getElementById("f-email").className = "f-email-720";
    document.getElementById("f-logo").className = "f-logo-720";
    document.getElementById("f-app-name").className = "f-app-name-720";

    document.getElementById("b-follow-text").className = "b-contact-text-1200";
    document.getElementById("b-question-text").className = "b-contact-text-1200";
    document.getElementById('b-log-winstore').className = "b-log-winstore-720";
    document.getElementById("b-img-appstore").className = "b-img-appstore-720";
    document.getElementById("b-img-winstore").className = "b-img-winstore-720";
    document.getElementById("b-app-links-container").className = "b-app-links-container-720";
    document.getElementById("app-links-cont").className = "b-links-cont-720";
    document.getElementById("b-mail-text").className = "b-mail-text-720";
    document.getElementById("b-main-text").className = "b-main-text-720";
    document.getElementById("b-main-img-container-2").className = "hidden";
    document.getElementById("b-main-img-container").className = "b-main-img-cont-720";
    document.getElementById("b-main-img").className = "b-main-img-720";
    document.getElementById("clouds").className = "";
    document.getElementById("grp-clouds-1").classList.remove("b-clouds")
    document.getElementById("grp-clouds-2").classList.remove("b-clouds")

    document.getElementById("h-language-butt").className = "h-language-butt-720";
    document.getElementById("h-language-butt-content").className = "h-language-butt-content-720";
}

function set960Styles(){

    document.getElementById("f-contiener").className = "footer";
    document.getElementById("f-email").className = "f-email-960";
    document.getElementById("f-logo").className = "f-logo-960";
    document.getElementById("f-app-name").className = "f-app-name-960";

    document.getElementById("b-follow-text").className = "b-contact-text-1200";
    document.getElementById("b-question-text").className = "b-contact-text-1200";
    document.getElementById("b-app-links-container").className = "b-app-links-container-960";
    document.getElementById("b-img-appstore").className = "b-img-appstore-960";
    document.getElementById("b-img-winstore").className = "b-img-winstore-960";
    document.getElementById("app-links-cont").className = "b-links-cont-960";
    document.getElementById("b-mail-text").className = "b-mail-text-960";
    document.getElementById("b-main-text").className = "b-main-text-960";
    document.getElementById("b-main-img-container-2").className = "hidden";
    document.getElementById("b-main-img-container").className = "b-main-img-cont-960";
    document.getElementById("b-main-img").className = "b-main-img-960";
    document.getElementById('b-log-winstore').className = "b-log-winstore-960";
    document.getElementById("clouds").className = "";
    document.getElementById("grp-clouds-1").classList.remove("b-clouds")
    document.getElementById("grp-clouds-2").classList.remove("b-clouds")

    document.getElementById("h-language-butt").className = "h-language-butt-960";
    document.getElementById("h-language-butt-content").className = "h-language-butt-content-960";
}

function set1200Styles(){

    document.getElementById("f-contiener").className = "footer";
    document.getElementById("f-email").className = "f-email-1200";
    document.getElementById("f-logo").className = "f-logo-1200";
    document.getElementById("f-app-name").className = "f-app-name-1200";

    document.getElementById("b-follow-text").className = "b-contact-text-1200";
    document.getElementById("b-question-text").className = "b-contact-text-1200";
    document.getElementById("b-img-appstore").className = "b-img-appstore-1200";
    document.getElementById("b-img-winstore").className = "b-img-winstore-1200";
    document.getElementById("b-app-links-container").className = "b-app-links-container-1200";
    document.getElementById("app-links-cont").className = "b-links-cont-1200";
    document.getElementById("b-mail-text").className = "b-mail-text-1200";
    document.getElementById("b-main-text").className = "b-main-text-1200";
    document.getElementById("b-main-img-container-2").className = "hidden";
    document.getElementById("b-main-img-container").className = "b-main-img-cont-1200";
    document.getElementById("b-main-img").className = "b-main-img-1200";
    document.getElementById('b-log-winstore').className = "b-log-winstore-1200";
    document.getElementById("clouds").className = "";
    document.getElementById("grp-clouds-1").classList.remove("b-clouds");
    document.getElementById("grp-clouds-2").classList.remove("b-clouds");    

    document.getElementById("h-language-butt").className = "h-language-butt-1200";
    document.getElementById("h-language-butt-content").className = "h-language-butt-content-1200";
}
