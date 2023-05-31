function avg(data) {
    // your code here
    let total = 0;
    for(let product in data.products) {
        total += data.products[product].price;
    }
    return total / data.size;
}
console.log(
    avg({
        size: 3,
        products: [
            {
                name: 'Product 1',
                price: 100,
            },
            {
                name: 'Product 2',
                price: 700,
            },
            {
                name: 'Product 3',
                price: 250,
            },
        ],
    })
); // should print the average price of all products