function binarySearchPosition(numbers, target) {
    // your code here
    let numSize = numbers.length;
    let left = 0, right = numSize-1;
    while(left <= right) {
        let mid = left + Math.floor((right - left) / 2);
        if(numbers[mid] == target) return mid;
        else if(numbers[mid] > target) right = mid - 1;
        else if(numbers[mid] < target) left = mid + 1;
    }
    return -1;
}
console.log(binarySearchPosition([1, 2, 5, 6, 7], 1)); // should print 0
console.log(binarySearchPosition([1, 2, 5, 6, 7], 6)); // should print 3