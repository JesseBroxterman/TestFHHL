$(document).ready(function () {
    let datatable = $("#record-search-results").DataTable({
        "processing": true,
        stateSave: true,
        ajax: {
            type: 'GET',
            url: window.getPath("~/Home/RecordSearchAjax"),
            data: function (d) {
                d.ReferralDateStart = $('#ReferralDateStart').val();
                d.ReferralDateEnd = $('#ReferralDateEnd').val();
                d.CaregiverName = $('#CaregiverName').val();
                d.ChildName = $('#ChildName').val();
                d.AssignedTo = $('#AssignedTo').val();
                d.DateOfBirth = $('#DateOfBirth').val();
                d.DeletedRecords = $('#DeletedRecords').val();
                return d;
            },
            error: function (xhr, error, code) {
                if (code != "abort") {
                    showAlert("danger", "Error", alertErrorMessage);
                }
            }
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
                title: 'Referral Dates',
                render: {
                    sort: 'referralDatesSortable',
                    display: function (data, type, row) {
                        return row['referralDates'].join("<br/>");
                    }
                }
            },
            {
                visible: true,
                data: 'childNames',
                title: 'Child Name(s)',
                render: function (data, type, row) {
                    return data.join("<br/>");
                }
            },
            {
                visible: true,
                data: 'assignedToLabels',
                title: 'Assigned To',
                render: function (data, type, row) {
                    return data.join("<br/>")
                }
            },
            {
                visible: true,
                data: null,
                title: 'Date of Birth',
                render: {
                    sort: 'dateOfBirthSortable',
                    display: 'dateOfBirth'
                }
            },
        ],
        autoWidth: false,
        "order": [[1, "desc"], [2, "desc"]],
        "dom": '<"row"<"col-12 col-md"><"col-12 col-md-auto">><"row"<"col-12"<"table-scrolling"t>>><"row align-items-center"<"col-12 col-md mb-2 mb-md-0"i><"col-12 col-md-auto"p>>r',
        "language": {
            "processing": 'Loading results... <i class="fa fa-spinner fa-spin" style="margin-left:5px;"></i>',
            "emptyTable": "There are no requests that match the above filter criteria."
        },
        pageLength: 25,
        createdRow: function (row, data, dataIndex, cells) {
            let url = window.getPath("~/Caregiver/Dashboard?id=" + data.id);
            $(row).attr('data-url', url);
            $(row).attr('tabindex', 0);
        },
    });

    $(".filter-control:not([placeholder])").on("change", function () {
        datatable.ajax.reload();
    });

    $("body").on("keypress click", "#record-search-results tr", function (e) {
        if (e.which === 13 || e.type === 'click') {
            let url = $(this).data("url");
            if (url) {
                window.location.href = url;
            }
        }
    });
});
