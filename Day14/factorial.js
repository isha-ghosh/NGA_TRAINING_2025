function isFactorial(number) {
    let fact = 1, i = 1;
    while (fact < number) {
        i++;
        fact *= i;
    }
    if (fact === number) {
        console.log(`${number} is the factorial of ${i}`);
    } else {
        console.log(`${number} is not a factorial of any integer`);
    }
}

isFactorial(6);  
