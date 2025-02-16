var express =require('express');
var app=express();
var port=3000;


app.use((req,res,next)=>{
    console.log(`Request Method: ${req.method}, Request URL: ${req.url}`);
    next();
});
//static middleware:serve static files from public directory
app.use(express.static("public"));





//if index.html is not in the public folder
app.get("/",(req,res)=>{
    res.sendFile(__dirname+"/index1.html");
});






app.listen(port,()=>{
    console.log(`server running`);
});