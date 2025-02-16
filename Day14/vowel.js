function isVowel(char) {
    const vowels = ['a', 'e', 'i', 'o', 'u'];
    if (vowels.includes(char.toLowerCase())) {
        console.log(`${char} is a vowel`);
    } else {
        console.log(`${char} is not a vowel`);
    }
}

isVowel('A');  
