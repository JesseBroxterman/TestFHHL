
$("body").on("click", ".tempalert", function (e) {
    window.alert("Feature not yet implemented");
    e.stopPropagation();
    e.preventDefault();
});

(function () {
    var appPath = null;
    function getAppPath() {
        if (appPath === null) {
            var temp = $("script").filter("[src*='/js/snco.']")[0].src;
            var index = temp.indexOf("/js/snco.");
            appPath = temp.substring(0, index);
        }
        return appPath;
    }
    window.getPath = function (inPath) {
        if (typeof inPath == "string" && inPath.length > 0 && inPath.charAt(0) == "~")
            return getAppPath() + inPath.substring(1);
        return inPath;
    };
})();

function showAlert(alertClass, title, body) {
    var container = $('#alertContainer');

    var alert = '<div class="alert alert-' + alertClass + ' alert-dismissible" role="alert">' +
        '<button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>' +
        '<strong>' + title + '</strong> ' + body +
    '</div>';

    container.append(alert);
}

const alertErrorMessage = "We're sorry, something unexpectedly went wrong while your request was being processed. We automatically log errors like this and a notification will be sent to the team to look into what happened. " +
    "If this is an emergency and needs a more immediate resolution, contact the Help Desk at extension 5555.";

/*removing datatables_info from keyboard accessibility*/
$('.dataTables_info').prop('tabIndex', -1);


$("body").on("click", ".modal-delete-confirm-show", function (e) {
    $(".edit-modal-footer").hide();
    $(".delete-modal-footer").css("display", "flex");
});

//cancel delete modal
$("body").on("click", ".modal-delete-cancel", function (e) {
    $(".edit-modal-footer").show();
    $(".delete-modal-footer").hide();
});

//set default modal-footer to edit-modal-footer
$(".modal").on("hidden.bs.modal", function (e) {
    $(".edit-modal-footer").show();
    $(".delete-modal-footer").hide();
});
