var express = require("express");
var app = express();
// ensures express js program i want to run
// http://localhost:1111/
app.get("/", (req, res) => {
    res.send("This is My First Program in Express JS...");
})
//http://localhost:1111/showFullName/isha/gho
app.get("/showFullName/:firstName/:lastName", (req,res) => {
    const firstName = req.params.firstName;
    const lastName = req.params.lastName;
    let fullName = firstName + " " +lastName;
    res.send("Full Name is  " +fullName);    
})
//http://localhost:1111/showInfo/kol/wi
app.get("/showInfo/:city/:company", (req,res) => {
    const city = req.params.city;
    const company = req.params.company;
    res.send("City is  " +city+ " Company is  " +company);
})
//http://localhost:1111/show/isha
app.get("/show/:name", (req, res) => {
    const name = req.params.name;
    res.send("Student Name is " +name);
})
//http://localhost:1111/ajay
app.get("/ajay", (req, res) => {
    res.send("Hi I am Ajay...")
})
//http://localhost:1111/gayathri
app.get("/gayathri", (req, res) => {
    res.send("Hi I am Gayathri...")
})
app.listen(1111, (req, res) => {
    console.log("Node Js Application Started...with Port 1111");
})

// ensures node js application is running in port 1111