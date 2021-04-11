/* ======================================
                   Login
   ====================================== */

$("#login div.eye .eye-img").click(function () {
    var input1 = $("#Password").attr("type");

    if (input1 == "password") {
        $("#Password").attr("type", "text");
    } else {
        $("#Password").attr("type", "password");
    }
});

$("#signUp form .form-group:nth-child(4) div.eye .eye-img").click(function () {
    var input1 = $("#su-password").attr("type");

    if (input1 == "password") {
        $("#su-password").attr("type", "text");
    } else {
        $("#su-password").attr("type", "password");
    }
});

$("#signUp form .form-group:nth-child(5) div.eye .eye-img").click(function () {
    var input1 = $("#su-password1").attr("type");

    if (input1 == "password") {
        $("#su-password1").attr("type", "text");
    } else {
        $("#su-password1").attr("type", "password");
    }
});

$("#change form .form-group:nth-child(1) div.eye .eye-img").click(function () {
    var input4 = $("#cp-old").attr("type");

    if (input4 == "password") {
        $("#cp-old").attr("type", "text");
    } else {
        $("#cp-old").attr("type", "password");
    }
});

$("#change form .form-group:nth-child(2) div.eye .eye-img").click(function () {
    var input5 = $("#cp-new").attr("type");

    if (input5 == "password") {
        $("#cp-new").attr("type", "text");
    } else {
        $("#cp-new").attr("type", "password");
    }
});

$("#change form .form-group:nth-child(3) div.eye .eye-img").click(function () {
    var input6 = $("#cp-confirm").attr("type");

    if (input6 == "password") {
        $("#cp-confirm").attr("type", "text");
    } else {
        $("#cp-confirm").attr("type", "password");
    }
});


// Show and Hide Navbar

function sticky_header() {
    var header_height = jQuery('.site-header').innerHeight() / 2;
    var scrollTop = jQuery(window).scrollTop();
    if (scrollTop > header_height) {
        jQuery('body').addClass('sticky-header');
        $("#home-page .logo-wrapper img").attr("src", "/Content/User/images/logo/dark-logo.png");
    } else {
        jQuery('body').removeClass('sticky-header');
        $("#home-page .logo-wrapper img").attr("src", "/Content/User/images/logo/white-logo.png");
    }
}

jQuery(document).ready(function () {
    sticky_header();
});

jQuery(window).scroll(function () {
    sticky_header();
});
jQuery(window).resize(function () {
    sticky_header();
});


/* =========================================
              Mobile Menu
============================================ */
$(function () {

    // Show mobile nav
    $("#mobile-nav-open-btn").click(function () {
        $("#mobile-nav").css("height", "100%");
    });

    // Hide mobile nav
    $("#mobile-nav-close-btn").click(function () {
        $("#mobile-nav").css("height", "0%");
    });

});


/* ==========================================
                User Profile   
============================================= */
/*Open calendar on clicking calendar input*/

$(function () {
    $("#up-dob").datetimepicker({
        timepicker: false,
        datepicker: true,
        format: 'd-m-Y' //Dateformat
    });
});

/* ==========================================
                    FAQ
============================================= */

// 1
$("#faq .faq1 .faq-plus")[0].addEventListener("click", function () {
    $("#faq .faq1 .faq-plus")[0].style.display = "none";
    $("#faq .faq1 .faq-minus")[0].style.display = "block";
});

$("#faq .faq1 .faq-minus")[0].addEventListener("click", function () {
    $("#faq .faq1 .faq-minus")[0].style.display = "none";
    $("#faq .faq1 .faq-plus")[0].style.display = "block";
});

// 2

$("#faq .faq2 .faq-plus")[0].addEventListener("click", function () {
    $("#faq .faq2 .faq-plus")[0].style.display = "none";
    $("#faq .faq2 .faq-minus")[0].style.display = "block";
});

$("#faq .faq2 .faq-minus")[0].addEventListener("click", function () {
    $("#faq .faq2 .faq-minus")[0].style.display = "none";
    $("#faq .faq2 .faq-plus")[0].style.display = "block";
});

// 3

$("#faq .faq3 .faq-plus")[0].addEventListener("click", function () {
    $("#faq .faq3 .faq-plus")[0].style.display = "none";
    $("#faq .faq3 .faq-minus")[0].style.display = "block";
});

$("#faq .faq3 .faq-minus")[0].addEventListener("click", function () {
    $("#faq .faq3 .faq-minus")[0].style.display = "none";
    $("#faq .faq3 .faq-plus")[0].style.display = "block";
});

// 4

$("#faq .faq4 .faq-plus")[0].addEventListener("click", function () {
    $("#faq .faq4 .faq-plus")[0].style.display = "none";
    $("#faq .faq4 .faq-minus")[0].style.display = "block";
});

$("#faq .faq4 .faq-minus")[0].addEventListener("click", function () {
    $("#faq .faq4 .faq-minus")[0].style.display = "none";
    $("#faq .faq4 .faq-plus")[0].style.display = "block";
});

// 5

$("#faq .faq5 .faq-plus")[0].addEventListener("click", function () {
    $("#faq .faq5 .faq-plus")[0].style.display = "none";
    $("#faq .faq5 .faq-minus")[0].style.display = "block";
});

$("#faq .faq5 .faq-minus")[0].addEventListener("click", function () {
    $("#faq .faq5 .faq-minus")[0].style.display = "none";
    $("#faq .faq5 .faq-plus")[0].style.display = "block";
});

// 6

$("#faq .faq6 .faq-plus")[0].addEventListener("click", function () {
    $("#faq .faq6 .faq-plus")[0].style.display = "none";
    $("#faq .faq6 .faq-minus")[0].style.display = "block";
});

$("#faq .faq6 .faq-minus")[0].addEventListener("click", function () {
    $("#faq .faq6 .faq-minus")[0].style.display = "none";
    $("#faq .faq6 .faq-plus")[0].style.display = "block";
});

// 7

$("#faq .faq7 .faq-plus")[0].addEventListener("click", function () {
    $("#faq .faq7 .faq-plus")[0].style.display = "none";
    $("#faq .faq7 .faq-minus")[0].style.display = "block";
});

$("#faq .faq7 .faq-minus")[0].addEventListener("click", function () {
    $("#faq .faq7 .faq-minus")[0].style.display = "none";
    $("#faq .faq7 .faq-plus")[0].style.display = "block";
});