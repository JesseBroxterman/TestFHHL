$(document).ready(function () {
    var datatable = $("#referral-search-results").DataTable({
        "processing": true,
        stateSave: true,
        ajax: {
            type: 'POST',
            url: window.getPath("~/Referral/RecordSearchAjax"),
            data: function (d) {
                d.ReferralDateStart = $('#ReferralDateStart').val();
                d.ReferralDateEnd = $('#ReferralDateEnd').val();
                d.CaregiverName = $('#CaregiverName').val();
                d.Program = $('#Program').val();
                d.ChildName = $('#ChildName').val();
                d.AssignedTo = $('#AssignedTo').val();
                d.ReferralSourceIds = $('#ReferralSourceIds').val();
                d.Result = $('#Result').val();
                d.DeletedRecords = $("#DeletedRecords").val();
                return d;
            },
            error: function (xhr, error, code) {
                if (code != "abort") {
                    showAlert("danger", "Error", alertErrorMessage);
                }            }
        },
        columns: [
            {
                visible: false,
                data: 'id'
            },
            {
                visible: true,
                data: 'caregiverName',
                title: 'Caregiver',
            },
            {
                visible: true,
                data: null,
                title: 'Referral Date',
                render: {
                    sort: 'referralDateSortable',
                    display: 'referralDate'
                }
            },
            {
                visible: true,
                data: 'childName',
                title: 'Child Name'
            },
            {
                visible: true,
                data: 'assignedTo',
                title: 'Assigned To'
            },
            {
                visible: true,
                data: 'referralSourceLabels',
                title: 'Referral Source(s)',
                render: function (data, type, row) {
                    return data.join("<br/>")
                }
            },
            {
                visible: true,
                data: 'program',
                title: 'Program'
            },
            {
                visible: true,
                data: 'result',
                title: 'Result'
            }

        ],
        autoWidth: false,
        "order": [[2, "desc"]],
        "dom": '<"row"<"col-12 col-md"><"col-12 col-md-auto">><"row"<"col-12"<"table-scrolling"t>>><"row align-items-center"<"col-12 col-md mb-2 mb-md-0"i><"col-12 col-md-auto"p>>r',
        "language": {
            "processing": 'Loading results... <i class="fa fa-spinner fa-spin" style="margin-left:5px;"></i>',
            "emptyTable": "There are no requests that match the above filter criteria."
        },
        pageLength: 25,
        createdRow: function (row, data, dataIndex, cells) {
            var url = window.getPath("~/Referral/Edit?id=" + data.id);
            $(row).attr('data-url', url);
            $(row).attr('tabindex', 0);
        },
    });

    $(".filter-control").on("change", function () {
        datatable.ajax.reload();
    });

    $("body").on("keypress click", "#referral-search-results tr", function (e) {
        if (e.which === 13 || e.type === 'click') {
            var url = $(this).data("url");
            if (url) {
                window.location.href = url;
            }
        }
    });
});
