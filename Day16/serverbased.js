/*var http =require('http');
http.createServer(function(request,response){
    //argument based callback function
    response.writeHead(200,{"content-type":"text/html"})
    response.end("Hello World");
}).listen(8080);
//localhost:8080
*/



var express=require('express');//it will load express framework which willallow with the server
var app=express(); //it is representing expresss application
app.set('viewEngine','jade')//viewEngine allow us to render dynamic html page (here we are using jade engine)           /viewEngine allows us to rerender dynamic html page
app.get('/myapp/',function(request,response){     //"/"it will setup a http root url (http:://localhost:3000/myapp)
    response.send("Hello Express");
    
})
var server=app.listen(3000,function(){
    console.log("http listen on port 3000");
});