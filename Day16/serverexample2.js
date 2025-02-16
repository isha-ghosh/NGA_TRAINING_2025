const express=require('express');
const app=express();
const port=3000;
app.get('/',(request,response)=>{
    response.send("Hello everyone!!");
});


app.get('/about',(request,response)=>{
    response.send("About us!!");
});


app.get('/contact',(request,response)=>{
    response.send("Contact us!!");
});



app.listen(port,()=>{
    console.log(`Server is running:${port}`);
});