function sumArrayElements(arr) {
    let sum = 0;
    for (let i = 0; i < arr.length; i++) {
        sum += arr[i];
    }
    console.log(`Sum of array elements: ${sum}`);
}

sumArrayElements([1, 2, 3, 4, 5]);

