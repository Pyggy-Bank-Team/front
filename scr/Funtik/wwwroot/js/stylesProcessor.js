var styles = ["mobile", "720", "960", "1200"];

function resize(i, width){

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