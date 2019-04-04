



$("#Where_Live_Child").change(function () {

        var value = $(this).val();
        if (value === "others") {
            $("#Name_Live_chiled").removeAttr("readonly", "readonly");
        } if (value === "Father_Mother" || value === "female" || value ==="father") {
            $("#Name_Live_chiled").attr("readonly", "readonly");
        }
    });





    
$(function () {
        $(".Evaluation").datepicker({
            dateFormat: "yy/mm/dd",
            changeMonth: true,
            changeYear: true,
            buttonText: "<i class='fa fa-calendar'></i>"
        }).datepicker("setDate", new Date());

});


$(function () {
    $(".nowdate").datepicker({
        dateFormat: "yy/mm/dd",
        changeMonth: true,
        changeYear: true,
        buttonText: "<i class='fa fa-calendar'></i>"
    }).datepicker("setDate", new Date());

});


    
$(function () {
        $(".datepickerDOBUY").datepicker({
            dateFormat: 'dd/mm/yy',

            changeMonth: true,
            changeYear: true,
            yearRange: '1980:+0',
            buttonText: "<i class='fa fa-calendar'></i>"

        }).on('change', function () {
            var age = getAge(this);
            $('#Age').val(age);
            console.log(age);
          

        });

    function getAge(dateVal) {
        var
    birthday = new Date(dateVal.value),
    today = new Date(),
    ageInMilliseconds = new Date(today - birthday),
    years = ageInMilliseconds / (24 * 60 * 60 * 1000 * 365.25),
    months = 12 * (years % 1),
    days = Math.floor(30 * (months % 1));
return Math.floor(years) + ' years ' + Math.floor(months) + ' months ' + days + ' days';

}
});



//$("#myform").validate({
//        onsubmit: true,
//    rules: {
//        n_Patient: "required",
//        email: {
//        required: true,
//    email: true
//},

//        select_gander:{
//        required: true
//}
//},
//    messages: {
//        name: "Please specify your name",
//        email: {
//        required: "We need your email address to contact you",
//    email: "Your email address must be in the format of name@domain.com"
//},
//        select_gander:{
//        required: "Select to male or female "
//}
//}
//});




