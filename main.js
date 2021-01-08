// JavaScript source code
const beanVarietyUrl = "https://localhost:5001/api/beanvariety/";

const beanButton = document.querySelector("#bean-button");
beanButton.addEventListener("click", () => {
    getAllBeanVarieties()
        .then(beanVarieties => {
            console.log(beanVarieties);
        })
});

function getAllBeanVarieties() {
    return fetch(beanVarietyUrl).then(resp => resp.json());
}

/////

const coffeeUrl = "https://localhost:5001/api/coffee/";

const coffeeButton = document.querySelector("#coffee-button");
coffeeButton.addEventListener("click", () => {
    getAllCoffees()
        .then(coffees => {
            console.log(coffees);
        })
})

function getAllCoffees() {
    return fetch(coffeeUrl).then(resp => resp.json());
}