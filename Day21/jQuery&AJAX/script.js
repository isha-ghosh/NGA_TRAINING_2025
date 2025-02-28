console.log("Welcome to jQuery AJAX Example");
$(document).ready(function(){
    //load
    $('#output').load("text.txt",function(response,statusTxt,xhr){
        console.log(response);
        console.log(statusTxt);
        console.log(xhr);
    })

    //get
    $.get("https://jsonplaceholder.typicode.com/users",function(data,status){
        console.log(data,status);

    })

    //post
    $.post("https://jsonplaceholder.typicode.com/posts",
     {title:"dummy text",body:"its the body"},
     function(data,status){
        console.log(data,status);

    })
})