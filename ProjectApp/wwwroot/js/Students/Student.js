
//$(function(){
//    $("#btn").click(function () {
//        LoadStudent()
//    })
//})


//function LoadStudent() {
//    $.ajax({
//        url: baseUrl + "Student/GetAllStudent",
//        method="GET",
//        success: function (result) {
//            console.log(result)
//        }
//    })
//}




$(function () {

    $("#btn").click(function () {
        Student();


    }) 
})



function Student() {

    if ($('#selectclass').val() == 'All') {
        alert();

        $.ajax({
            type: "GET",
            url: baseUrl + "Student/GetAllStudent",
            success: function (result) {
                console.log(result)
            }
        })
    }
    else {
        alert();
        $.ajax({
            type: "GET",
            url: baseUrl + "Student/GetStudentByClass",
            success: function (result) {
                console.log(result)
            }
        })
    }
}