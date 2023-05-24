/**
 * Count how many ‘a’ and ‘b’ letters are in the given input and return the total number.
 */
function countAandB(input) {
    let count = 0;
    input.forEach(function(char) {
        if(char == 'a' || char == 'b') {
            count++;
        }
    });
    return count;
}

/** 
 * Convert English letters to numbers, let ‘a’ to be 1, ‘b’ to be 2, and so on.
 */
function toNumber(input) {
    let output = [];
    for(let i = 0; i < input.length; i++) {
        output.push(input[i].charCodeAt(0) - 96);
    }
    return output;
}

let input1 = ['a', 'b', 'c', 'a', 'c', 'a', 'c'];
console.log(countAandB(input1));
console.log(toNumber(input1));

let input2 = ['e', 'd', 'c', 'd', 'e'];
console.log(countAandB(input2));
console.log(toNumber(input2));