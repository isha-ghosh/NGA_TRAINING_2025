function displayEvenElements(arr) {
  let evenElements = [];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 === 0) {
      evenElements.push(arr[i]);
    }
  }

  console.log(`Even elements: ${evenElements}`);
}

displayEvenElements([1, 2, 3, 4, 5, 6, 7, 8]);
