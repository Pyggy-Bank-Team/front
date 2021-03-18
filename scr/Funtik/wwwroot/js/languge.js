function showLanguges(event){
    var languges = document.getElementById("h-dropdonw-languges");
    if(languges){
        if(languges.style.display === "none"){
            languges.style.display = "block";
        }else{
            languges.style.display = "none";
        }
    }
}

function changeToRussian(){
    document.getElementById('h-language-butt-content').innerText = "Русский";
    document.getElementById('h-description').innerText = "Приложение для планирования бюджета";
    document.getElementById('b-main-text').innerText = "Бесплатное приложение для планирования бюджета";
    document.getElementById('b-question-text').innerText = "По любым вопросам:";
    document.getElementById('b-follow-text').innerText = "Мы есть:";
}

function changeToEnglish(){
    document.getElementById('h-language-butt-content').innerText = "English";
    document.getElementById('h-description').innerText = "Home budget planing platform";
    document.getElementById('b-main-text').innerText = "Free and easy to use budget planning application";
    document.getElementById('b-question-text').innerText = "For any questions:";
    document.getElementById('b-follow-text').innerText = "Follow us:";
}