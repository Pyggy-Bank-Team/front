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

    var footerEmail = document.getElementById("f-email");
    if(footerEmail){
        footerEmail.className = "";
        footerEmail.className = "f-email-mobile";
    }

    var footerLogo = document.getElementById("f-logo");
    if(footerLogo){
        footerLogo.className = "";
        footerLogo.className = "f-logo-moblie";
    }

    var footerAppName = document.getElementById("f-app-name");
    if(footerAppName){
        footerAppName.className = "";
        footerAppName.className = "f-app-name-mobile";
    }

    var mainText = document.getElementById("b-main-text");
    if(mainText){
        mainText.className = "";
        mainText.className = "b-main-text-720";
    }

    var mainIgmCont = document.getElementById("b-main-img-container-2");
    if(mainIgmCont){
        mainIgmCont.style.cssText="";
    }

    var mainIgmCont = document.getElementById("b-main-img-container");
    if(mainIgmCont){
        mainIgmCont.style.cssText="display:none";
    }

    var mainIgm = document.getElementById("b-main-img");
    if(mainIgm){
        mainIgmCont.style.cssText="display:none";
    }

    var cloudsCont = document.getElementById("clouds");
    if(cloudsCont){
        cloudsCont.classList.add("b_clouds-cont-mobile");
    }

    var grpClouds1 = document.getElementById("grp-clouds-1");
    if(grpClouds1){
        grpClouds1.classList.add("b-clouds")
    }

    var grpClouds2 = document.getElementById("grp-clouds-2");
    if(grpClouds2){
        grpClouds2.classList.add("b-clouds")
    }

    var headerImg = document.getElementById("header-img");
    if(headerImg){
        headerImg.className = "";
        headerImg.classList.add("h-logo-mobile");
    }    

    var headerLogAndName = document.getElementById("header-log-name");
    if(headerLogAndName){
        headerLogAndName.classList.remove("display-inline");
        headerLogAndName.classList.add("display-flex");
    }

    var headerLog = document.getElementById("header-log");
    if(headerLog){
        headerLog.classList.remove("display-inline");
        headerLog.classList.add("display-flex");
        headerLog.style.cssText="margin:0 auto; align-items:center;";
    }

    var headerName = document.getElementById("header-app-name");
    if(headerName){
        headerName.style.cssText = "";
    }
    
    var headerNameAndDescription = document.getElementById("header-name-description");
    if(headerNameAndDescription){
        headerNameAndDescription.style.cssText="display:none";
    }
    
    var langueButton = document.getElementById("header-language-button");
    if(langueButton){
        langueButton.classList.remove("f-right");
        langueButton.style.cssText="display:none";
    }

    var circle = document.getElementById("circle");
    if(circle){
        circle.classList.remove("body-circle");
        circle.style.cssText="display:none";
    }   
}

function set720Styles(){

    var footerEmail = document.getElementById("f-email");
    if(footerEmail){
        footerEmail.className = "";
        footerEmail.className = "f-email-720";
    }

    var footerLogo = document.getElementById("f-logo");
    if(footerLogo){
        footerLogo.className = "";
        footerLogo.className = "f-logo-720";
    }

    var footerAppName = document.getElementById("f-app-name");
    if(footerAppName){
        footerAppName.className = "";
        footerAppName.className = "f-app-name-720";
    }

    var mainText = document.getElementById("b-main-text");
    if(mainText){
        mainText.className = "";
        mainText.className = "b-main-text-720";
    }

    var mainIgmCont = document.getElementById("b-main-img-container-2");
    if(mainIgmCont){
        mainIgmCont.style.cssText="display:none";
    }

    var mainIgmCont = document.getElementById("b-main-img-container");
    if(mainIgmCont){
        mainIgmCont.style.cssText = "";
        mainIgmCont.className = "";
        mainIgmCont.className = "b-main-img-cont-720";
    }

    var mainIgm = document.getElementById("b-main-img");
    if(mainIgm){
        mainIgmCont.style.cssText = "";
        mainIgm.className = "";
        mainIgm.className = "b-main-img-720";
    }

    var cloudsCont = document.getElementById("clouds");
    if(cloudsCont){
        cloudsCont.classList.remove("b_clouds-cont-mobile");
    }

    var grpClouds1 = document.getElementById("grp-clouds-1");
    if(grpClouds1){
        grpClouds1.classList.remove("b-clouds")
    }

    var grpClouds2 = document.getElementById("grp-clouds-2");
    if(grpClouds2){
        grpClouds2.classList.remove("b-clouds")
    }

    var headerImg = document.getElementById("header-img");
    if(headerImg){
        headerImg.className = "";
        headerImg.classList.add("h-logo-720");
    }

    var hAppName = document.getElementById("h-app-name");
    if(hAppName){
        hAppName.className = "";
        hAppName.className = "h-title-app-name-720";
    }

    var hDescription = document.getElementById("h-description");
    if(hDescription){
        hDescription.className = "";
        hDescription.className = "h-title-description-720";
    }

    var headerLogAndName = document.getElementById("header-log-name");
    if(headerLogAndName){
        headerLogAndName.classList.add("display-inline");
        headerLogAndName.classList.remove("display-flex");
    }

    var headerLog = document.getElementById("header-log");
    if(headerLog){
        headerLog.classList.add("display-inline");
        headerLog.classList.remove("display-flex");
        headerLog.style.cssText="";
    }

    var headerName = document.getElementById("header-app-name");
    if(headerName){
        headerName.style.cssText = "display:none";
    }    

    var headerNameAndDescription = document.getElementById("header-name-description");
    if(headerNameAndDescription){
        headerNameAndDescription.style.cssText="";
    }

    var langueButt = document.getElementById("h-language-butt");
    if(langueButt){
        langueButt.className = "";
        langueButt.className = "h-language-butt-720";
    }

    var langueButtContent = document.getElementById("h-language-butt-content");
    if(langueButtContent){
        langueButtContent.className = "";
        langueButtContent.className = "h-language-butt-content-720";
    }

    var langueButton = document.getElementById("header-language-button");
    if(langueButton){
        langueButton.style.cssText="";
        langueButton.classList.add("f-right");        
    }

    var circle = document.getElementById("circle");
    if(circle){
        circle.style.cssText="";
        circle.classList.add("body-circle");
        circle.style.height="500px";
        circle.style.width ="500px";   
    }  
}

function set960Styles(){

    var footerEmail = document.getElementById("f-email");
    if(footerEmail){
        footerEmail.className = "";
        footerEmail.className = "f-email-960";
    }

    var footerLogo = document.getElementById("f-logo");
    if(footerLogo){
        footerLogo.className = "";
        footerLogo.className = "f-logo-960";
    }

    var footerAppName = document.getElementById("f-app-name");
    if(footerAppName){
        footerAppName.className = "";
        footerAppName.className = "f-app-name-960";
    }

    var mainText = document.getElementById("b-main-text");
    if(mainText){
        mainText.className = "";
        mainText.className = "b-main-text-960";
    }

    var mainIgmCont = document.getElementById("b-main-img-container-2");
    if(mainIgmCont){
        mainIgmCont.style.cssText="display:none";
    }

    var mainIgmCont = document.getElementById("b-main-img-container");
    if(mainIgmCont){
        mainIgmCont.style.cssText = "";
        mainIgmCont.className = "";
        mainIgmCont.className = "b-main-img-cont-960";
    }

    var mainIgm = document.getElementById("b-main-img");
    if(mainIgm){
        mainIgmCont.style.cssText = "";
        mainIgm.className = "";
        mainIgm.className = "b-main-img-960";
    }

    var cloudsCont = document.getElementById("clouds");
    if(cloudsCont){
        cloudsCont.classList.remove("b_clouds-cont-mobile");
    }

    var grpClouds1 = document.getElementById("grp-clouds-1");
    if(grpClouds1){
        grpClouds1.classList.remove("b-clouds")
    }

    var grpClouds2 = document.getElementById("grp-clouds-2");
    if(grpClouds2){
        grpClouds2.classList.remove("b-clouds")
    }

    var headerImg = document.getElementById("header-img");
    if(headerImg){
        headerImg.className = "";
        headerImg.classList.add("h-logo-960");
    }

    var hAppName = document.getElementById("h-app-name");
    if(hAppName){
        hAppName.className = "";
        hAppName.className = "h-title-app-name-960";
    }

    var hDescription = document.getElementById("h-description");
    if(hDescription){
        hDescription.className = "";
        hDescription.className = "h-title-description-960";
    }

    var headerLogAndName = document.getElementById("header-log-name");
    if(headerLogAndName){
        headerLogAndName.classList.add("display-inline");
        headerLogAndName.classList.remove("display-flex");
    }

    var headerLog = document.getElementById("header-log");
    if(headerLog){
        headerLog.classList.add("display-inline");
        headerLog.classList.remove("display-flex");
        headerLog.style.cssText="";
    }

    var headerName = document.getElementById("header-app-name");
    if(headerName){
        headerName.style.cssText = "display:none";
    } 

    var headerNameAndDescription = document.getElementById("header-name-description");

    if(headerNameAndDescription){
        headerNameAndDescription.style.cssText="";
    }

    var langueButt = document.getElementById("h-language-butt");
    if(langueButt){
        langueButt.className = "";
        langueButt.className = "h-language-butt-960";
    }

    var langueButtContent = document.getElementById("h-language-butt-content");
    if(langueButtContent){
        langueButtContent.className = "";
        langueButtContent.className = "h-language-butt-content-960";
    }

    var langueButton = document.getElementById("header-language-button");
    if(langueButton){
        langueButton.style.cssText="";
        langueButton.classList.add("f-right");        
    }

    var circle = document.getElementById("circle");
    if(circle){
        circle.style.cssText="";
        circle.classList.add("body-circle");
        circle.style.height="600px";
        circle.style.width ="600px";   
    }   
}

function set1200Styles(){

    var footerEmail = document.getElementById("f-email");
    if(footerEmail){
        footerEmail.className = "";
        footerEmail.className = "f-email-1200";
    }

    var footerLogo = document.getElementById("f-logo");
    if(footerLogo){
        footerLogo.className = "";
        footerLogo.className = "f-logo-1200";
    }

    var footerAppName = document.getElementById("f-app-name");
    if(footerAppName){
        footerAppName.className = "";
        footerAppName.className = "f-app-name-1200";
    }

    var mainText = document.getElementById("b-main-text");
    if(mainText){
        mainText.className = "";
        mainText.className = "b-main-text-1200";
    }

    var mainIgmCont = document.getElementById("b-main-img-container-2");
    if(mainIgmCont){
        mainIgmCont.style.cssText="display:none";
    }

    var mainIgmCont = document.getElementById("b-main-img-container");
    if(mainIgmCont){
        mainIgmCont.style.cssText = "";
        mainIgmCont.className = "";
        mainIgmCont.className = "b-main-img-cont-1200";
    }

    var mainIgm = document.getElementById("b-main-img");
    if(mainIgm){
        mainIgmCont.style.cssText = "";
        mainIgm.className = "";
        mainIgm.className = "b-main-img-1200";
    }

    var cloudsCont = document.getElementById("clouds");
    if(cloudsCont){
        cloudsCont.classList.remove("b_clouds-cont-mobile");
    }

    var grpClouds1 = document.getElementById("grp-clouds-1");
    if(grpClouds1){
        grpClouds1.classList.remove("b-clouds")
    }

    var grpClouds2 = document.getElementById("grp-clouds-2");
    if(grpClouds2){
        grpClouds2.classList.remove("b-clouds")
    }

    var headerImg = document.getElementById("header-img");
    if(headerImg){
        headerImg.className = "";
        headerImg.classList.add("h-logo-1200");
    }

    var hAppName = document.getElementById("h-app-name");
    if(hAppName){
        hAppName.className = "";
        hAppName.className = "h-title-app-name-1200";
    }

    var hDescription = document.getElementById("h-description");
    if(hDescription){
        hDescription.className = "";
        hDescription.className = "h-title-description-1200";
    }

    var headerLogAndName = document.getElementById("header-log-name");
    if(headerLogAndName){
        headerLogAndName.classList.add("display-inline");
        headerLogAndName.classList.remove("display-flex");
    }

    var headerLog = document.getElementById("header-log");
    if(headerLog){
        headerLog.classList.add("display-inline");
        headerLog.classList.remove("display-flex");
        headerLog.style.cssText="";
    }
    var headerName = document.getElementById("header-app-name");
    if(headerName){
        headerName.style.cssText = "display:none";
    } 

    var headerNameAndDescription = document.getElementById("header-name-description");
    if(headerNameAndDescription){
        headerNameAndDescription.style.cssText="";
    }

    var langueButt = document.getElementById("h-language-butt");
    if(langueButt){
        langueButt.className = "";
        langueButt.className = "h-language-butt-1200";
    }

    var langueButtContent = document.getElementById("h-language-butt-content");
    if(langueButtContent){
        langueButtContent.className = "";
        langueButtContent.className = "h-language-butt-content-1200";
    }

    var langueButton = document.getElementById("header-language-button");
    if(langueButton){
        langueButton.style.cssText="";
        langueButton.classList.add("f-right");        
    }

    var circle = document.getElementById("circle");
    if(circle){
        circle.style.cssText="";
        circle.classList.add("body-circle");   
    }   
}