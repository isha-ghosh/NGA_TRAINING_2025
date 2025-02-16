var express =require('express');
var app=express();
var port=3000;

//Built in Middleware to parse JSON body
app.use(express.json());

//GET Request----http://localhost:3000
app.get("/",(req,res)=>{
    res.send("Welcome to Express JS Middleware");
});
//POST Request-----http://localhost:3000/data
app.post('/data',(req,res)=>{
    const{id,name}=req.body;
   // res.json({"data: ":{name}, "id: ":{id}});
    res.json({messsage:"Post request received:: ", data:{name},id:{id}})
});

//PUT -----UPDATE Request-----http://localhost:3000/update
app.put('/update',(req,res)=>{
    const{id,name}=req.body;
  
    res.json({messsage:"Put request received:: ", data:{name},id:{id}})
});

//DELETE Request-----http://localhost:3000/delete
app.delete('/delete',(req,res)=>{
    
  
    res.json({messsage:" Data deleted!! "})
});

//To sstrt the server
app.listen(port,()=>{
    console.log(`server running`);
});


