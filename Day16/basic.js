//variables and datatypes
console.log("variable and its datatypes");
let name="ihjjsdc";
const age=79;
var city="del";
console.log(`Name:${name}, Age:${age}, city:${city}`);


//arrrow function
const add=(a,b)=>a+b;
console.log(`Sum= ${add(2,6)}`);


//class
class Person
{

    // let name; ---->for block scope
    constructor (name,age,city)
    {
        this.name=name;
        this.age=age;
        this.city=city;
    }
    display()
    {
        console.log(`Name:${this.name}, Age:${this.age}, city:${this.city}`);
    }
}

const p1=new Person("Nitin",54,"kolkata");
p1.display();

//MAP Function
const nos=[4,5,6,78,50];
const d=nos.map((num)=>num*2);
console.log(`${d}`);

//Access specifier
class student
{
    sname="isha";  //public
    marks=99;   //public
    #age=22;    //private
    displayinfo()
    {
        console.log(`Name: ${this.sname}\nMarks: ${this.marks}\nAge: ${this.#age}`);
    }
}
const s=new student();
s.displayinfo();
s.marks;
s.sname;
//s.#age;-------------->cant be accessed as private