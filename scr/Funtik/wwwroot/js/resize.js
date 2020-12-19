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