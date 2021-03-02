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

    var mailText = document.getElementById("b-mail-text");
    if(mailText){
        mailText.className = "b-mail-text-mobile";
    }

    var followText = document.getElementById("b-follow-text");
    if(followText){
        followText.classList = "b-contact-text-mobile";
    }

    var questionText = document.getElementById("b-question-text");
    if(questionText){
        questionText.className = "b-contact-text-mobile";
    }

    var logWinStoreContainer = document.getElementById('b-log-winstore');
    if(logWinStoreContainer){
        logWinStoreContainer.className = "b-log-winstore-mobile";
    }

    var logAppStore = document.getElementById("b-img-appstore");
    if(logAppStore){
        logAppStore.className = "b-img-appstore-mobile";
    }

    var logWinStore = document.getElementById("b-img-winstore");
    if(logWinStore){
        logWinStore.className = "b-img-winstore-mobile";
    }

    var appLinksContainer = document.getElementById("b-app-links-container");
    if(appLinksContainer){
        appLinksContainer.className = "b-app-links-container-mobile";
    }

    var socialMedias = document.getElementById("app-links-cont");
    if(socialMedias){
        socialMedias.className = "b-links-cont-mobile";
    }

    var mainText = document.getElementById("b-main-text");
    if(mainText){
        mainText.className = "b-main-text-mobile";
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

    var grpClouds1 = document.getElementById("grp-clouds-1");
    if(grpClouds1){
        grpClouds1.className = "hidden";
    }

    var grpClouds2 = document.getElementById("grp-clouds-2");
    if(grpClouds2){
        grpClouds2.className = "hidden";
    }

    var headerImg = document.getElementById("header-img");
    if(headerImg){
        headerImg.className = "h-logo-mobile";
    }    

    var headerLogAndName = document.getElementById("header-log-name");
    if(headerLogAndName){
        headerLogAndName.className = "display-flex";
    }

    var headerLog = document.getElementById("header-log");
    if(headerLog){
        headerLog.className = "display-flex";
    }

    var headerName = document.getElementById("h-name-mobile");
    if(headerName){
        headerName.className = "h-title-mobile";
    }
    
    var headerNameAndDescription = document.getElementById("h-name-description");
    if(headerNameAndDescription){
        headerNameAndDescription.className = "hidden";
    }

    var langueButtContent = document.getElementById("h-language-butt-content");
    if(langueButtContent){
        langueButtContent.className = "h-language-butt-content-mobile";
    }
    
    var langueButton = document.getElementById("header-language-button");
    if(langueButton){
        langueButton.className = "h-language-button-mobile";        
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

    var followText = document.getElementById("b-follow-text");
    if(followText){
        followText.classList = "b-contact-text-1200";
    }

    var questionText = document.getElementById("b-question-text");
    if(questionText){
        questionText.className = "b-contact-text-1200";
    }

    var logWinStorer = document.getElementById('b-log-winstore');
    if(logWinStorer){
        logWinStorer.className = "b-log-winstore-720";
    }

    var logAppStore = document.getElementById("b-img-appstore");
    if(logAppStore){
        logAppStore.className = "b-img-appstore-720";
    }

    var logWinStore = document.getElementById("b-img-winstore");
    if(logWinStore){
        logWinStore.className = "b-img-winstore-720";
    }

    var appLinksContainer = document.getElementById("b-app-links-container");
    if(appLinksContainer){
        appLinksContainer.className = "b-app-links-container-720";
    }

    var socialMedias = document.getElementById("app-links-cont");
    if(socialMedias){
        socialMedias.className = "b-links-cont-720";
    }

    var mailText = document.getElementById("b-mail-text");
    if(mailText){
        mailText.className = "b-mail-text-720";
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

    var headerName = document.getElementById("h-name-mobile");
    if(headerName){
        headerName.className = "hidden";
    }

    var headerNameAndDescription = document.getElementById("h-name-description");
    if(headerNameAndDescription){
        headerNameAndDescription.className = "h-title-1200";
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
        langueButton.className = "f-right";        
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

    var followText = document.getElementById("b-follow-text");
    if(followText){
        followText.classList = "b-contact-text-1200";
    }

    var questionText = document.getElementById("b-question-text");
    if(questionText){
        questionText.className = "b-contact-text-1200";
    }

    var appLinksContainer = document.getElementById("b-app-links-container");
    if(appLinksContainer){
        appLinksContainer.className = "b-app-links-container-960";
    }

    var logAppStore = document.getElementById("b-img-appstore");
    if(logAppStore){
        logAppStore.className = "b-img-appstore-960";
    }

    var logWinStore = document.getElementById("b-img-winstore");
    if(logWinStore){
        logWinStore.className = "b-img-winstore-960";
    }

    var socialMedias = document.getElementById("app-links-cont");
    if(socialMedias){
        socialMedias.className = "b-links-cont-960";
    }

    var mailText = document.getElementById("b-mail-text");
    if(mailText){
        mailText.className = "b-mail-text-960";
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

    var logWinStorer = document.getElementById('b-log-winstore');
    if(logWinStorer){
        logWinStorer.style.cssText = "";
        logWinStorer.className = "";
        logWinStorer.className = "b-log-winstore-960";
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

    var headerName = document.getElementById("h-name-mobile");
    if(headerName){
        headerName.className = "hidden";
    }

    var headerNameAndDescription = document.getElementById("h-name-description");
    if(headerNameAndDescription){
        headerNameAndDescription.className = "h-title-1200";
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
        langueButton.className = "f-right";        
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

    var followText = document.getElementById("b-follow-text");
    if(followText){
        followText.classList = "b-contact-text-1200";
    }

    var questionText = document.getElementById("b-question-text");
    if(questionText){
        questionText.className = "b-contact-text-1200";
    }

    var logAppStore = document.getElementById("b-img-appstore");
    if(logAppStore){
        logAppStore.className = "b-img-appstore-1200";
    }

    var logWinStore = document.getElementById("b-img-winstore");
    if(logWinStore){
        logWinStore.className = "b-img-winstore-1200";
    }

    var appLinksContainer = document.getElementById("b-app-links-container");
    if(appLinksContainer){
        appLinksContainer.className = "b-app-links-container-1200";
    }

    var socialMedias = document.getElementById("app-links-cont");
    if(socialMedias){
        socialMedias.className = "b-links-cont-1200";
    }

    var mailText = document.getElementById("b-mail-text");
    if(mailText){
        mailText.className = "b-mail-text-1200";
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

    var logWinStorer = document.getElementById('b-log-winstore');
    if(logWinStorer){
        logWinStorer.style.cssText = "";
        logWinStorer.className = "";
        logWinStorer.className = "b-log-winstore-1200";
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

    var headerName = document.getElementById("h-name-mobile");
    if(headerName){
        headerName.className = "hidden";
    }

    var headerNameAndDescription = document.getElementById("h-name-description");
    if(headerNameAndDescription){
        headerNameAndDescription.className = "h-title-1200";
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
        langueButton.className = "f-right";        
    }  
}