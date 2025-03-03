var express = require("express");
var bodyParser = require("body-parser");
var cors = require("cors");
var app = express();

app.use(cors());//enables to access the service
app.use(bodyParser.json());
let users = [
    {"userid":1,"name":"Prasanna","basic":88234},
    {"userid":2,"name":"Rajesh","basic":90032},
    {"userid":3,"name":"Kalyan","basic":91153},
    {"userid":5,"name":"Srikar","basic":98823},
    {"userid":4,"name":"Abhishiek","basic":90023},
]
//http://localhost:1113/show
app.get("/show", (req,res) => {
    res.status(200).json(users);
})

//http://localhost:1113/search/1
app.get("/search/:userid", (req, res) => {
    let found = users.find(function (item) {
        return item.userid === parseInt(req.params.userid);
    });
    if (found) {
        res.status(200).json(found);
    } else {
        res.sendStatus(404);
    }
})
app.post('/add', function (req, res) {
   
    let newItem = {
        userid: req.body.userid,
        name: req.body.name,
        basic: req.body.basic
        // roll_no: req.body.roll_no
    }

    users.push(newItem);

    res.status(201).json({
        'message': "successfully created"
    });
});


app.listen(1113, (req, res) => {
    console.log("Node Js Application Started...");
})