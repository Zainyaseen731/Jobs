

    $('#iconified').on('keyup', function () {
            var input = $(this);
            if (input.val().length === 0) {
        input.addClass('empty');
            } else {
        input.removeClass('empty');
}
});

        function typevalid() {
            if (document.Addjob.type.value == "") {

        document.getElementById("type_error").innerHTML = "type field is empty!";
    document.Addjob.type.focus();
}
            if (document.Addjob.type.value != "") {
        document.Addjob.title.focus();

}
}

        function titlevalid() {
            if (document.Addjob.title.value == "") {

        document.getElementById("title_error").innerHTML = "title field is empty!";
    document.Addjob.title.focus();
}
            else {
        document.Addjob.company.focus();

}
}


        function companyvalid() {
            if (document.Addjob.company.value == "") {

        document.getElementById("company_error").innerHTML = "company field is empty!";
    document.Addjob.company.focus();
}
            else {
        document.Addjob.location.focus();

}
}

        function locationvalid() {
            if (document.Addjob.location.value == "") {

        document.getElementById("location_error").innerHTML = "location field is empty!";
    document..location.focus();
}
}
