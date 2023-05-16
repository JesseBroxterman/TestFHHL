$("#utilities-toggle").on("click", function () {
    var utilities = document.getElementById("utilities");
    if (utilities.style.display === "block") {
        $("#utilities").hide();
        $("#utilities-caret").removeClass("fa-caret-up");
        $("#utilities-caret").addClass("fa-caret-down");
    } else {
        $("#utilities").show();
        $("#utilities-caret").removeClass("fa-caret-down");
        $("#utilities-caret").addClass("fa-caret-up");
    }
    return false;
});

$(document).ready(function () {
    //Set sidenav sizing when the page first loads:
    setNavState();
});

function setCookie(key, value) {
    var expires = new Date();
    expires.setTime(expires.getTime() + (8192 * 24 * 60 * 60 * 1000));     //22 years    8192 is number of days
    document.cookie = key + '=' + value + ';expires=' + expires.toUTCString() + '; path=/';
}
function getCookie(key) {
    var keyValue = document.cookie.match('(^|;) ?' + key + '=([^;]*)(;|$)');
    return keyValue ? keyValue[2] : null;
}
function setNavState() {
    var ww = document.body.clientWidth;
    var c = getCookie('asideNav');

    switch (c) {
        case "0":
            $('#internalSideNav').addClass('nav-xs');
            break;
        case "1":
            $('#internalSideNav').removeClass('nav-xs');
            break;
        case null:
            if (ww < 992) {
                $('#internalSideNav').addClass('nav-xs');
            } else if (ww >= 992) {
                $('#internalSideNav').removeClass('nav-xs');
            }
            break;
        default:
            break;
    }
}
$('#navToggle').click(function () {
    var c = getCookie('asideNav');
    switch (c) {
        case "0":
            setCookie('asideNav', 1);
            break;
        case "1":
            setCookie('asideNav', 0);
            break;
        case null:
            setCookie('asideNav', 0);
            break;
        default:
            setCookie('asideNav', 1);
            break;
    }
});

$(".datepicker").flatpickr({
    dateFormat: "m-d-Y",
    defaultDate: null,
    allowInput: true
});

$(".timepicker").flatpickr({
    enableTime: true,
    noCalendar: true,
    dateFormat: "h:i K",
});

$(".datetimepicker").flatpickr({
    enableTime: true,
})


$(".zip").inputmask("99999");