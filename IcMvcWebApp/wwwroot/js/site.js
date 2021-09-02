// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function MainFunction() {
    alert("Братан, ну это пиздэц. Ты все обработчики автоматически создавал что ли? Учи, наверное лучше JavaScript. Красивые интерфейсы верстать это здорово. И там тоже до хера учить, но там по проще.")

    var destroyShit = document.getElementById("destroyShit");

    destroyShit.children[0].remove()
    destroyShit.children[0].remove()
    destroyShit.children[0].remove()
    

    var paragraph = document.createElement("h4");
    paragraph.innerHTML = "Закажите нормального разработчика";
    paragraph.style.color = "grey";
    paragraph.style.backgroundColor = "lightgrey";
    destroyShit.appendChild(paragraph);

    var linkInDescript = document.createElement("a");
    linkInDescript.href = "https://www.facebook.com/7Rv0RNxBc8OOw3I9";
    linkInDescript.innerHTML = "Ссылочка в описании";

    destroyShit.appendChild(linkInDescript);

    var newBody = document.body;
    
    var newButton = document.createElement("button");
    destroyShit.appendChild(newButton);

    newButton.innerHTML = "Нажми ещё разок";
    newButton.onclick = function () {

        newBody.innerHTML = "";
        newBody.innerHTML = "Ну всё, пиздец. Сломал :) Это всё сделано простым JavaScript. Даже не реактом или чем-то супер сложным." }

}
