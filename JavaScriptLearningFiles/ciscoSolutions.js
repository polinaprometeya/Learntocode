//THEIR solutions:
//5.10.1.8
// function fibbIter(n) {
//     let a = 0, b = 1;
//     for (let i = 2; i <= n; i++) {
//         let c = a;
//         a = b;
//         b += c;        
//     }
//     return b;
// }

//5.10.1.7

//let fibb = n => n == 0 ? 0 : (n == 1 ? 1 : fibb(n - 1) + fibb(n - 2));

//5.10.1.6
let fibbRec = function (n) {
    let retVal = 0;
    if (n != 0) {
        if (n === 1) {
            retVal = 1;
        } else {
            retVal = fibbRec(n - 1) + fibbRec(n - 2);
        }
    }
    return retVal;
}


//5.10.1.5
let counter = 1;
let intervalId = setInterval(function () {
    console.log(counter++);
}, 2000);

setTimeout(function () {
    clearInterval(intervalId)
}, 20000);


//5.10.1.4

let action = (callback, a, b) => callback(a, b);
// or
let action = function (callback, a, b) {
    return callback(a, b);
}
// or
function action(callback, a, b) {
    return callback(a, b);
}

//5.10.1.3
let add = (a, b) => !Number.isInteger(a) || !Number.isInteger(b) ? NaN : a + b;
let sub = (a, b) => !Number.isInteger(a) || !Number.isInteger(b) ? NaN : a - b;
let mult = (a, b) => !Number.isInteger(a) || !Number.isInteger(b) ? NaN : a * b;

//5.10.1.2
function add(a, b) {
    if (!Number.isInteger(a) || !Number.isInteger(b)) {
        return NaN;
    }
    return a + b;
}

function sub(a, b) {
    if (!Number.isInteger(a) || !Number.isInteger(b)) {
        return NaN;
    }
    return a - b;
}

function mult(a, b) {
    if (!Number.isInteger(a) || !Number.isInteger(b)) {
        return NaN;
    }
    return a * b;
}

//5.10.1.1
let number = prompt("Enter a random number");
if(number > 90 && number < 110) {
    alert("Bingo!");
} else {
    alert("Miss");
}

//cisco solution for the decending sorting
// let numbers = [50, 10, 40, 30, 20];
// let sorted = numbers.sort((a, b) => b - a);
// console.log(sorted); // [10, 20, 30, 40, 50]

//5.1.8
window.addEventListener("click", function() {
    console.log("clicked!");
});


//4.1.11.6
while (true) {
    let firstNumber = prompt("Enter first number");
    let secondNumber = prompt("Enter second number");
    let operand = prompt("Enter operand (+, -, * or /)");
    let result;

    if (firstNumber === "Q" || secondNumber === "Q" || operand === "Q") {
        break;
    }

    firstNumber = Number(firstNumber);
    secondNumber = Number(secondNumber);

    if (!Number.isNaN(firstNumber) && !Number.isNaN(secondNumber)) {
        switch (operand) {
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
            case "*":
                result = firstNumber * secondNumber;
                break;
            case "/":
                result = firstNumber / secondNumber;
                break;
            default:
                result = "Error: unknown operand";
        }
    } else {
        result = "Error: at least one of the entered values is not a number";
    }
    alert(result);
}

//4.1.11.5
let vessel = {
    LATITUDE: 40.07288,
    LONGITUDE: 154.48535,
    COURSE: 285.6,
    SPEED: 14.0,
    IMO: 9175717,
    NAME: "MARENO"
}

for (let key in vessel) {
    console.log(`${key} -> ${vessel[key]}`);
}

//4.1.11.3
    let numbers = [21, 45, 100, 12, 11, 78, 61, 4, 39, 22];

    for (number of numbers) {
        console.log(number);
    }

    for (number of numbers) {
        if (number % 2 === 0) {
            console.log(number);
        }
    }

    for (number of numbers) {
        if (number > 10 && number < 60) {
            console.log(number);
        }
    }

    
//4.1.2
    let isOver = false;
    let counter = 1;
    
    while (isOver != true) {
        let continueLoop = confirm(`[${counter}] Continue the loop?`);
        isOver = continueLoop === true ? false : true;
        counter = counter + 1;
    }

    //4.1.5
    let names = [];
    let isOver = false;
    while (!isOver) {
        let name = prompt("Enter another name or press cancel.");
        if (name != null) {
            names.push(name);
        } else {
            isOver = true;
        }
    }
    
    for (let i = 0; i < names.length; i++){
        console.log(names[i]);
    }

// //4.1.6

let cities = [
    { name: "New York", population: 18.65e6 },
    { name: "Cairo", population: 18.82e6 },
    { name: "Mumbai", population: 19.32e6 },
    { name: "São Paulo", population: 20.88e6 },
    { name: "Mexico City", population: 21.34e6 },
    { name: "Shanghai", population: 23.48e6 },
    { name: "Delhi", population: 25.87e6 },
    { name: "Tokyo", population: 37.26e6 }
];
 
for (let city of cities) {
    if (city.population > 20e6) {
        console.log(`${city.name} (${city.population})`);
    }
}


// //4.1.7 
let user = {
    name: "Calvin",
    surname: "Hart",
    age: 66,
    email: "CalvinMHart@teleworm.us"
};
 
for (let key in user) {
    console.log(key); // -> name, surname, age, email
};

// //4.1.8

let i = 0;
// An infinite loop
while (true){
    console.log(i);
    i++;
    if (i >= 5) {
        break;
    }
}
 
alert(`Exited the loop with a break (${i}).`);

for (let i = 0; i < 10; i++) {
    if (i == 3) {
        continue;
    }
    console.log(i);
}


//4.0.8.3
    let firstNumber = Number(prompt("Enter first number"));
    let secondNumber = Number(prompt("Enter second number"));
    let operand = prompt("Enter operand (+, -, * or /)");
    let result;

    if (!Number.isNaN(firstNumber) && !Number.isNaN(secondNumber)) {
        switch (operand) {
            case "+": result = firstNumber + secondNumber; break;
            case "-": result = firstNumber - secondNumber; break;
            case "*": result = firstNumber * secondNumber; break;
            case "/": result = firstNumber / secondNumber; break;
            default: result = "Error: unknown operand";
        }
    } else {
        result = "Error: at least one of the entered values is not a number";
    }
    alert(result);

//4.0.8.2
    let number4082 = prompt("Enter a random number");
    let message = (number4082 > 90 && number4082 < 110) ? "Bingo!": "Miss";
    alert(message);

//4.0.8.1
    let number4081 = prompt("Enter a random number");
    if(number4081 > 90 && number4081 < 110) {
        alert("Bingo!");
    } else {
        alert("Miss");
}

//3.0.10.3
    console.log(true || false);  
    console.log(false ||! false);  
    console.log(false || false || true);  
    console.log(true || false && false && true);


//2.2.3.3
    let newBook = {
        title: "Learning JavaScript Design Patterns",
        author: "Addy Osmani",
        pages: 254
    };
    books.push(newBook);
    console.log(books.length);
    console.log(books[0].title);
    console.log(books[1].title);
    console.log(books[2].title);
    console.log(books[3].title);

    //2.2.2
        let users =[
            {
            name: "Calvin",
            surname: "Hart",
            age: 66,
            email: "CalvinMHart@teleworm.us"
            },
            {
            name: "Mateus",
            surname: "Pinto",
            age: 21,
            email: "MateusPinto@dayrep.com"
            }
        ];
        
        console.log(users[0].name); // -> Calvin
        console.log(users[1].age); // -> 21

        let  days  =  ["Sun",  "Mon",  "Tue",  "Wed",  "Thu",  "Fri",  "Sat"];
        let  day  =  "Sunday";
        
        console.log(typeof  days);  //  ->  object
        console.log(typeof  day);  //  ->  string
        
        console.log(days  instanceof  Array);  //  ->  true
        console.log(day  instanceof  Array);  //  ->  false


    //2.2.1
        let  name1  =  "Calvin";
        let  surname1  =  "Hart";
        let  age1  =  66;
        let  email1  =  "CalvinMHart@teleworm.us";
        
        let  name2  =  "Mateus";
        let  surname2  =  "Pinto";
        let  age2  =  21;
        let  email2  =  "MateusPinto@dayrep.com";

    //2.1.11.6
        const str1 = 42 + + "1";
        console.log(str1, "43");


    //2.1.11.3
        let b1 = Boolean( BigInt(Number("1234")));
        console.log(`${b1} [${typeof b1}]`);

        // or

        let s = "1234";
        let n = Number(s);
        let bi = BigInt(n);
        let b = Boolean(bi);
        console.log(`${b} [${typeof b}]`);



    //2.0.14.2
        const rosePrice = 8;
        const lilyPrice = 10;
        const tulipPrice = 2;

        let numberOfRoses = 70;
        let numberOfLilies = 50;
        let numberOfTulips = 120;

        let rosesValue = rosePrice * numberOfRoses;
        let liliesValue = lilyPrice * numberOfLilies;
        let tulipsValue = tulipPrice * numberOfTulips;

        let total = rosesValue + liliesValue + tulipsValue;

        console.log("Rose – unit price:", rosePrice, ", quantity:", numberOfRoses, ", value:", rosesValue);
        console.log("Lily – unit price:", lilyPrice, ", quantity:", numberOfLilies, ", value:", liliesValue);
        console.log("Tulip – unit price:", tulipPrice, ", quantity:", numberOfTulips, ", value:", tulipsValue);
        console.log("Total: ", total);

        numberOfRoses = numberOfRoses - 20;
        numberOfLilies = numberOfLilies - 30;

        rosesValue = rosePrice * numberOfRoses;
        liliesValue = lilyPrice * numberOfLilies;
        tulipsValue = tulipPrice * numberOfTulips;

        total = rosesValue + liliesValue + tulipsValue;

        console.log("Rose – unit price:", rosePrice, ", quantity:", numberOfRoses, ", value:", rosesValue);
        console.log("Lily – unit price:", lilyPrice, ", quantity:", numberOfLilies, ", value:", liliesValue);
        console.log("Tulip – unit price:", tulipPrice, ", quantity:", numberOfTulips, ", value:", tulipsValue);
        console.log("Total: ", total);

    //2.0.14.1
        let rosePrice1 = 8;
        let lilyPrice1 = 10;
        let tulipPrice1 = 2;

        let numberOfRoses1 = 70;
        let numberOfLilies1 = 50;
        let numberOfTulips1 = 120;

        let rosesValue1 = rosePrice1 * numberOfRoses1;
        let liliesValue1 = lilyPrice1 * numberOfLilies1;
        let tulipsValue1 = tulipPrice1 * numberOfTulips1;

        let total1 = rosesValue1 + liliesValue1 + tulipsValue1;
        console.log("Rose – unit price:", rosePrice1, ", quantity:", numberOfRoses1, ", value:", rosesValue1);
        console.log("Lily – unit price:", lilyPrice1, ", quantity:", numberOfLilies1, ", value:", liliesValue1);
        console.log("Tulip – unit price:", tulipPrice1, ", quantity:", numberOfTulips1, ", value:", tulipsValue1);
        console.log("Total: ", total1);

    //2.0.10.0

        // var globalGreeting = "Good ";
        
        // function testFunction() {
        //     var localGreeting = "Morning ";
        //     console.log("function:");
        //     console.log(globalGreeting);
        //     console.log(localGreeting);
        // }
        
        // testFunction();
        
        // console.log("main program:");
        // console.log(globalGreeting);
        // console.log(localGreeting); // -> Uncaught ReferenceError: localGreeting is not defined

