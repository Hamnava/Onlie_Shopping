var OpenModal = {};

OpenModal.LoadModal = function () {
    var url = window.location.hash.toLowerCase();
    if (!url.startsWith("#showmodal")) {
        return;
    }
    url = url.split("showmodal=")[1];
    $.get(url,
        null,
        function (htmlPage) {
            $("#ModalContent").html(htmlPage);
            const container = document.getElementById("ModalContent");
            const forms = container.getElementsByTagName("form");
            const newForm = forms[forms.length - 1];
            $.validator.unobtrusive.parse(newForm);
            showModal();
        }).fail(function (error) {
            setTimeout(function () {
                Swal.fire({
                    position: 'top-end',
                    icon: 'error',
                    title: 'خطا در انجام عملیات .',
                    showConfirmButton: false,
                    timer: 1800
                })

            }, 50)
            setTimeout(function () { window.location.reload() }, 2000)
        });
};


function showModal() {
    $("#MainModal").modal("show");
}

$(document).ready(function () {
    window.onhashchange = function () {
        OpenModal.LoadModal();
    };

    $("#MainModal").on("shown.bs.modal",
        function () {
            window.location.hash = "#";

        }
    );

    $(document).on("submit",
        'form[data-ajax="true"]',
        function (e) {
            e.preventDefault();
            var form = $(this);
            const method = form.attr("method").toLocaleLowerCase();
            const url = form.attr("action");

            if (method === "get") {
                const data = form.serializeArray();
                $.get(url, data, function () { });
            }
            else {
                var formData = new FormData(this);
                $.ajax({
                    url: url,
                    type: "post",
                    data: formData,
                    enctype: "multipart/form-data",
                    dataType: "json",
                    processData: false,
                    contentType: false,
                    success: function (data) {

                        message(data);

                    },
                    error: function (data) {
                        alert("خطا در انجام عملیات .");
                    }
                });
            }
            return false;
        }
    );
});
function message(final) {

    switch (final) {
        case 1:
            setTimeout(function () {
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'دیتا با موفقیت اضافه شد .',
                    showConfirmButton: false,
                    timer: 1800
                })

            }, 50)
            setTimeout(function () { window.location.reload() }, 2000)
            break;
        case 2:
            setTimeout(function () {
                Swal.fire({
                    position: 'top-start',
                    icon: 'success',
                    title: 'دیتا با موفقیت ویرایش شد .',
                    showConfirmButton: false,
                    timer: 1800
                })

            }, 50)
            setTimeout(function () { window.location.reload() }, 2000)
            break;

        case 3:
            setTimeout(function () {
                Swal.fire({
                    position: 'top-end',
                    icon: 'success',
                    title: 'دیتا با موفقیت حذف شد .',
                    showConfirmButton: false,
                    timer: 1800
                })

            }, 50)
            setTimeout(function () { window.location.reload() }, 2000)
            break;
        case 4:
            setTimeout(function () {
                Swal.fire({
                    position: 'top-end',
                    icon: 'error',
                    title: 'خطا در انجام عملیات .',
                    showConfirmButton: false,
                    timer: 1800
                })

            }, 50)
            setTimeout(function () { window.location.reload() }, 2000)
            break;
        case 5:
            setTimeout(function () {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'دیتا تکراری است .',
                    showConfirmButton: false,
                    timer: 1800
                })

            }, 50)
            setTimeout(function () { window.location.reload() }, 2000)
            break;
    }

}