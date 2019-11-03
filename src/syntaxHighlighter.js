let keywordsColors = [
{word: "class", color:"#F47E4B"},
{word: "var",  color:"#C88EE9"},
{word: "=", color:"#C88EE9"},
{word:'{', color:"#8DDCFE"},
{word:'}', color:"#8DDCFE"},
{word:";", color:"#8DDCFE"}];

let specialCharsColors = [
{word: '"', color: "#8DDCFE"}
];

function colorSyntax(){
    let codeSelector = document.querySelector(".code");
    let code = codeSelector.innerHTML;
    let splittedCode = code.split(" ");
    codeSelector.innerHTML = "";

    for (let i = 0; i < splittedCode.length; i++) {
        let color = findKeywordColor(splittedCode[i]);
        insertColorSpan(codeSelector,splittedCode[i], color);
    }    
}

function findKeywordColor(word){

    for (let i = 0; i < keywordsColors.length; i++) {
        if(keywordsColors[i].word === word){
            return keywordsColors[i].color;
        }
    }
    return null;
}

function insertColorSpan(insertToElement,word, color){    
    if(color !== null){
        insertToElement.innerHTML += `<span style="color: ${color};">${word} </span>`;
    }
    else{
        insertToElement.innerHTML += word + " ";
    }
}