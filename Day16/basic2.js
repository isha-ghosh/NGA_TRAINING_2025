/*//Destructuring
console.log("destructuring");
const user={username: "Isha Ghosh", email:"hjdbcsh@gmail.com"};
const{username,email}=user;
console.log(`username: ${username}\nEmail: ${email}`);

//Promises Async/Await

//step1 created a function that will return a promise
const fetchData =()=>{
    return new Promise((resolve) => {
        setTimeout(()=> { resolve("data fetched!!");

        },1000);    //1 sec delay
    });
};
//step2 created async function to handle the promise
async function getData()
{
    console.log("fetching data")
    //step3 wait for the promise to resolve using await
    const res =await fetchData();
    //step 4 display the result after the promose resolve
    console.log(res);
}
getData();*/

//await
async function fetchUser() {
    console.log("fetching dataa");
    let response=await fetch("https://jsonplaceholder.typicode.com/users/1");
    let user=await response.json();
    console.log("user data..................... ",user);
}
console.log("Initiate the process");
fetchUser();
console.log("Process Completed");


//.then
console.log("Initiate the process");
async function fetchUserr() {
    
    console.log("fetching dataa");
    fetch("https://jsonplaceholder.typicode.com/users/1")
    .then(response=> response.json())
    .then((user)=>console.log("user data: ",user));
}
fetchUserr();
console.log("Process Completed");