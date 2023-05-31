function count(input) {
    // your code here
    let obj = {};
    input.forEach(elem => {
        if(elem in obj) obj[elem] += 1;
        else obj[elem] = 1;
    });
    return obj
}

let input1 = ["a", "b", "c", "a", "c", "a", "x"];
console.log(count(input1));
// should print {a:3, b:1, c:2, x:1}

function groupByKey(input) {
    // your code here
    let obj = {};
    input.forEach(elem => {
        const key = elem.key;
        const value = elem.value;
        if(key in obj) obj[key] += value;
        else obj[key] = value;
    });
    return obj;
}

let input2 = [
    { key: "a", value: 3 },
    { key: "b", value: 1 },
    { key: "c", value: 2 },
    { key: "a", value: 3 },
    { key: "c", value: 5 },
];
console.log(groupByKey(input2));
// should print {a:6, b:1, c:7}