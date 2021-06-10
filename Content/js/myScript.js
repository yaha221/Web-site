function myFunction() {
    var x = document.getElementById("myTopnav");
    if (x.className === "topnav") {
        x.className = "topnav responsive";
    } else {
        x.className = "topnav";
    }
}
// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function() {scrollFunction()};

function scrollFunction() {
    var x = document.getElementById("myTopnav");
    if (document.body.scrollTop > 100 || document.documentElement.scrollTop > 100) {
        document.getElementById("myBtn").style.display = "block";
        x.className = "topnav scroll";
    } else {
        document.getElementById("myBtn").style.display = "none";
        x.className="topnav";
    }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}
function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}

/*footer*/

const clc = document.querySelector(".cancel");
const arr = document.querySelector(".arr_container");
const left_container = document.querySelector(".left_container");

arr.addEventListener("click", ()=>{
    arr.classList.add("active_arr");
    if(left_container.classList.contains("off")){
        left_container.classList.remove("off");
        left_container.classList.add("active_footer");
    }
});
clc.addEventListener("click", ()=>{
    arr.classList.remove("active_arr");
    if (left_container.classList.contains("active_footer")) {
        left_container.classList.remove("active_footer");
        left_container.classList.add("off");
    }
});