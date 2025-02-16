

// // Using the Fetch API to get data from the provided JSON endpoint
// fetch('https://dummy.restapiexample.com/api/v1/employees/get/json', {
//         method: 'GET',
//         headers: {
//             'Accept': 'application/json',
//         },
//     })
//        .then(response => response.json())
//        .then(response => console.log(JSON.stringify(response)))

function run() {

    // Creating Our XMLHttpRequest object 
    let xhr = new XMLHttpRequest();

    // Making our connection  
    let url = 'https://dummy.restapiexample.com/api/v1/employees';
    xhr.open("GET", url, true);

    // function execute after request is successful 
    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            console.log(this.responseText);
        }
    }
    // Sending our request 
    xhr.send();
}
run();
