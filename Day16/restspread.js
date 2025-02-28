// Example of rest and spread operator
const summ = (...nums) => nums.reduce((acc, curr) => acc + curr, 0);
console.log(`Sum using rest operator : ${summ(2, 4, 5, 6, 8)}`);



//spread operator combining array
const arr1 = [2, 3, 4];
const arr2 = [5, 6, 8];
const summing = [...arr1, ...arr2]; //  is used to expand the contents of an iterable (arrays , string  ) into individual elements.
console.log("array submittion :", summing);


//copying array
const originalArray = [1, 2, 3];
const copiedArray = [...originalArray];  // Creates a shallow copy

console.log(copiedArray); // Output: [1, 2, 3]


//combining objects
const obj1 = { name: "Alice", age: 25 };
const obj2 = { country: "USA", profession: "Engineer" };

const combinedObject = { ...obj1, ...obj2 };

console.log(combinedObject);
// Output: { name: 'Alice', age: 25, country: 'USA', profession: 'Engineer' }


//Passing Multiple Arguments to a Function
function sum(a, b, c) {
    return a + b + c;
}

const numbers = [1, 2, 3];
console.log(sum(...numbers)); // Output: 6


//Converting a String to an Array

const str = "Hello";
const strArray = [...str];

console.log(strArray); 
// Output: ['H', 'e', 'l', 'l', 'o']