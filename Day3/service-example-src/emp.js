var express = require("express");
var bodyParser = require("body-parser");
var cors = require("cors");
//cors is a security protocol known as cross origin permission which allows you to
//access your url in any programming language
var app = express();

app.use(bodyParser.json());
app.use(cors());

//ensures data to be converted to xml or json format u specify
//bodyparser predefined object
let employs = [
    {"empno":1,"name":"Prasanna","basic":88234},
    {"empno":2,"name":"Rajesh","basic":90032},
    {"empno":3,"name":"Kalyan","basic":91153},
    {"empno":4,"name":"Abhishiek","basic":90023},
    {"empno":5,"name":"Srikar","basic":98823},
]
//data to json 
app.get("/showemploy", (req,res) => {
    res.status(200).json(employs);
})

app.post('/addemploy', function (req, res) {
   
    let newItem = {
        empno: req.body.empno,
        name: req.body.name,
        basic: req.body.basic
       
    }

    employs.push(newItem);

    res.status(201).json({
        'message': "successfully created"
    });
});

app.get("/searchemploy/:empno", (req, res) => {
    let found = employs.find(function (item) {
        return item.empno === parseInt(req.params.empno);
    });
    if (found) {
        res.status(200).json(found);
    } else {
        res.sendStatus(404);
    }
})

app.listen(5555, (req, res) => {
    console.log("Node Js Application Started...");
})