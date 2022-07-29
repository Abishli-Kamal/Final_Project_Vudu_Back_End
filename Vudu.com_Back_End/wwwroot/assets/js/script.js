var filterbtn = document.getElementById("filterBtn");
var filterAll = document.querySelector(".filterAll");
var respMenu = document.getElementById("respMenu");
var respMenuFilters = document.querySelector(".respMenuFilters")
var main = document.getElementById("main");
var reset = document.querySelector(".reset");
var responsiveUl = document.querySelector(".responsiveUl");
var UhdMain = document.querySelector(".UhdMain")
const box = document.querySelectorAll(".footerToggle")

function openTrailer() {

    document.getElementById("myTrailer").style.width = "100%";

}

function closeTrailer() {
    document.getElementById("myTrailer").style.width = "0%";
}


function openNav() {
    document.getElementById("myNav").style.width = "100%";
}

function closeNav() {
    document.getElementById("myNav").style.width = "0%";
}

box.forEach(boxs => {
    boxs.addEventListener("click", () => {
        boxs.classList.toggle("active");
    });
});
filterbtn.addEventListener("click", function () {
    filterAll.classList.toggle("dBlock");
});
respMenu.addEventListener("click", function () {
    respMenuFilters.classList.toggle("dBlock");
    reset.classList.toggle("dBlock");
});
function PasswordShowHidden() {
    var input = document.getElementById("myInput")
    var hidden = document.getElementById("hide1")
    var show = document.getElementById("hide2")

    if (input.type === 'password') {
        input.type = "text";
        show.style.display = "block";
        hidden.style.display = "none";
    }
    else {
        input.type = "password";
        show.style.display = "none";
        hidden.style.display = "block";
    }
}


















