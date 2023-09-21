// animation in the span on the first page
let spanTexts=document.getElementsByTagName("span");
        window.onload=function(){
            for(spanText of spanTexts){
                spanText.classList.add("active");
            }
        }