var express =require('express');
var app=express();
var port=3000;

//application level middleware(which will run on every request)
app.use((req,res,next)=>{
    console.log("Aplication Level Middleware");
  
    next(); //pass control to next middleware or route
});
//route level middleware for /Logger route
const specialMiddleware=(req,res,next)=>{
    //console.log("Route leveel Middleware For/Logger");
    console.log("Time: ",new Date().toISOString());
    next(); //pass control to next handler for logger
};
app.get("/logger",specialMiddleware,(req,res)=>{
    console.log("Route handler for /Logger");
    res.send("Logger Page");
});

app.get("/display", (req,res)=>{
    console.log("Route handler for display");
    res.send("Normal Page");
});
//To sstrt the server
app.listen(port,()=>{
    console.log(`server running on Port http://localhost:3000`);
});