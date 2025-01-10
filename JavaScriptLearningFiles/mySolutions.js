// /**Exercise 6.1.8.1: 
// Write your own div function that will take two call arguments and return the result of dividing the first argument by the second. 
// In JavaScript, the result of dividing by zero is the value Infinity (or -Infinity, if we try to divide a negative number). 
// Change this. If you pass 0 as the second argument, your function should throw a RangeError exception with the appropriate message. 
// Prepare a test call of the function for both valid division and division by zero. */


 let div =  (a, b) => { 
     if (b == 0) { 
         throw new RangeError("You cannot divide by 0");} 
     return a / b; };

 console.log("division", div(4,1));


// /* Exersize 5.1.11
// Our program has grown quite a bit, making it a little hard to read. It is especially visible in the switch instruction, where most of the logic is enclosed. 
// Try to organize your program code by using functions. Define and call three functions in the appropriate places:

//     showContact: the function should take two arguments; the first is the list of contacts, 
//     and the second is the index number of the contact to display; inside the function, check if the correct arguments are passed, that is, 
//     if the contacts are an array (use the instanceofArray construction for this);

//     showAllContacts: the function should take one argument, the list of contacts; inside the function, check if the given argument is an array;

//     addNewContact: the function should take four arguments, a contact list and the data of the new contact, that is: name, phone, and number. 
//     before adding a new contact, check if the passed argument is an array and if the new contact data have any value.
//  */

 let contacts = [{
     name: "Maxwell Wright",
     phone: "(0191) 719 6495",
     email: "Curabitur.egestas.nunc@nonummyac.co.uk"
     }, {
     name: "Raja Villarreal",
     phone: "0866 398 2895",
     email: "posuere.vulputate@sed.com"
     }, {
     name: "Helen Richards",
     phone: "0800 1111",
     email: "libero@convallis.edu"
     }];

    
 let userAction = prompt("What do you want to do 1) Display the first contact, 2) Display the last contact, 3) Display all contacts, 4)Add new contact or 5)Stop here?", 0);

 let continue = true; 

 function getUserAction(userAction){
     let userAction = prompt("What do you want to do 1) Display the first contact, 2) Display the last contact, 3) Display all contacts, 4)Add new contact or 5)Stop here?", 0);
 }


 function showContact(userAction){
    if (userAction == 1){
         alert(`The current first contact is: ${contacts[0].name}`);
     } else if(userAction == 2){
         let lastConact = contacts.length - 1;
         alert(`Current the last contact is: ${contacts[lastConact].name}`);
     } else return userAction;
 }

 function showAllContacts(){
     let list = "";
     let count = 1;
     contacts.forEach(contact => {
     list += ' ' + count + '. ' + contact.name + '\n';
     count++;
     });
      alert(`Your contacts \n${list}`); 
     // for( let name in contacts) { console.log(`${name} -> ${contacts[name]}`);};
     // alert (`Your contacts \n${contacts.name}`);
    
 }

 function addNewContact(){
         let contact = {};
         contact.name = prompt("write your name:", "");
         contact.phone = prompt("Write your phone number:", "");
         contact.email = prompt("Write you email:", "");
         if (contact.name !== "" || contact.phone !== "" || contact.email !== "") { contacts.push(contact);
         } else { alert("Error. Contact information is missing")};
 }

 function userChoice(userAction){
     if (userAction <3 ){
         return showContact(userAction);
     } else if ( userAction == 3 ){
         return showAllContacts();
     } else if (userAction == 4) { 
         return addNewContact(); 
     } else if (userAction == 5){
         return alert("Tak for denne gang");
     } else {
         return;
         // return getUserAction();
     }
 }

 function operation(callback, callbackVariable , contactsVariable ){
    callback(callbackVariable);
 }

 // operation(userChoice, userAction, continue);
 operation(userChoice, userAction);

// //5.10.1.8

function fibbRec(n) { 
    temp1 = 0;
    temp2 = 1;
    next_value = 0;

for(i=0; i<n; i++){
    next_value = temp1 + temp2;
    temp1 = temp2;
    temp2 = next_value;
}
return temp1;
} 

 
console.log(fibbRec(0)); // -> 0
console.log(fibbRec(1)); // -> 1
console.log(fibbRec(4)); // -> 3
console.log(fibbRec(7)); // -> 13
console.log(fibbRec(9)); // -> 34
console.log(fibbRec(11)); // -> 89
    


//5.10.1.7

let fibbRec =  (n) => { if (n != 0) {n === 1 ? retVal = 1 : retVal = fibbRec(n - 1) + fibbRec(n - 2); return retVal; } else {return retVal = 0;}} 

 
console.log(fibbRec(0)); // -> 0
console.log(fibbRec(1)); // -> 1
console.log(fibbRec(4)); // -> 3
console.log(fibbRec(7)); // -> 13
console.log(fibbRec(9)); // -> 34
console.log(fibbRec(11)); // -> 89
    

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

console.log(fibbRec(4)); // -> 3
console.log(fibbRec(7)); // -> 13
console.log(fibbRec(9)); // -> 34
console.log(fibbRec(11)); // -> 89

// wrong
// function fibonacci (f) {
//     while (n > 1) {
//         result = n-1 + n-2;
//         n--;
//     }
//     return result;
// }
// console.log(fibonacci(9)); 

// let fibonacciNumber = (f) => f == 1 ? 1 : fibonacci(f);
// console.log(fibonacciNumber(9));




/*// Exercise 5.10.1.5
Write a program that will print out (to the console) consecutive integers 10 times,
 in two-second intervals (start with the number 1). 
Use the functions setInterval, clearInterval and setTimeout.*/


//based on their solution
let counter = 10;
let intervalId = setInterval(function () {
    console.log(counter--);
}, 1000);
setTimeout(function () {
    clearInterval(intervalId)
}, 11000);


// ------------------wrong
// let interval = function() {
//     let timerId = setInterval(1000) /*ms*/;
//     setTimeout(function(){clearInterval(timerId);}, 5500);
// }

// let counter = function (callback){
//     for( i=10; i>0; i-- ){ 
//         interval(callback);
//         console.log("count",i);
//     }
// }
// counter(interval);


//------------------wrong
// let setInterval = (a)=>{
    
//     console.log("wait", a, "ms");
//     return  setTimeout(countdown, a);    
    
// };

// let countdown = (callback, a)=>{
    
//     for( i=10; i>0; i-- ){
//         callback(a);
//         console.log(i);
//     }
// }

// countdown(setInterval, 1000);

// let clearInterval = (a)=>{
//     if (a!== NaN){clearTimeout(a);} else {return;}
// };


//------------------wrong
// // let setInterval = ()=>{
// //     for (let i = 0; i < 10; i++) {

// //         action();
// //         console.log("wait", i)
// //     }
// // };
// // let clearInterval = (a)=>{
// //     clearTimeout(a);
// // };

// // let action = (setInterval, a)=>{
// //  console.log("wait", a, "ms");
// // setTimeout(setInterval, a)
// // }
    
// // // for( i=10; i>0; i-- ){
// // // setInterval(a);
// // // console.log(i);
// // // }


// // setTimeout(setInterval, 2);


// //Exercise 5.10.1.4

let add = (a, b) => !Number.isInteger(a) || !Number.isInteger(b) ? NaN : a + b;
let sub = (a, b) => !Number.isInteger(a) || !Number.isInteger(b) ? NaN : a - b;
let mult = (a, b) => !Number.isInteger(a) || !Number.isInteger(b) ? NaN : a * b;

let action =  function(callback, a, b){
    console.log(callback(a,b));

}

action(add, 12, 10); // -> 22
action(sub, 12, 10); // -> 2
action(mult, 10, 10.1); // -> NaN



// //Exercise 5.10.1.3
 
let add = (a, b) => (!Number.isInteger(a) || !Number.isInteger(b)) ? NaN : a + b;
let sub = (a, b) => !Number.isInteger(a) || !Number.isInteger(b) ? NaN : a - b;
let mult = (a, b) => !Number.isInteger(a) || !Number.isInteger(b) ? NaN :  a * b;

console.log("control", add(10,1), sub(10,1) , mult(10,1));


/**Exercise 5.10.1.2: 
 
Write three functions with the names add, sub, and mult, which will take two numerical arguments.
 The functions are to check if the given arguments are integers (use Number.isInteger). 
 If not, they return NaN, otherwise they return the result of addition, subtraction, or multiplication respectively. 
 The functions are to be declared using a function statement.
Example of use and expected results:*/


// let input1 =  Number(prompt("add first number"));
// let input2 = Number(prompt("add second number"));

function add(a,b){
    if(Number.isInteger(a) && Number.isInteger(b)){
        return a + b;
    } else {return NaN;} 
}

function sub(a,b){
    if(Number.isInteger(a) && Number.isInteger(b)){
        return a - b;
    } else {return NaN;}   
}

function mult(a,b){
    if(Number.isInteger(a) && Number.isInteger(b)){
        return a * b;
    } else {return NaN;}
}

// function operations(a, b, add, sub, mult){
//      if(typeof(a) === 'number' && typeof(b)  === 'number' ){
//       add(a,b);
//       sub(a,b);
//       mult(a,b);
//         alert ("Your numbers give reults of addition:", add, "subtraction", sub , "and multiplication", mult);
//         console.log( "control", a, b, add, sub, mult);
//  }
// }

// operations(input1, input2, add, sub, mult);

console.log(add(12, 10)); // -> 22
console.log(sub(12, 10)); // -> 2
console.log(mult(12, 10.1)); // -> NaN


console.log( "control", add(10,1), sub(10,1), mult(10,1));



/*Exercise 5.10.1.1: 
Arrays in JavaScript have a sort method available which, as you might guess, allows you to sort its elements. 
This method takes as an argument a function that will compare two elements of the array. 
The function should return zero if we consider the arguments to be the same, a value less than zero if we consider the first one to be smaller than the second, and a value larger than zero otherwise. 
Take a look at the example: */

let numbers = [50, 10, 40, 30, 20];
function compareNumbers(a, b) {
     let retVal = 0;
     if (a < b) {
         retVal = -1;
     } else if(a > b) {
         retVal = 1;
     }
     return retVal;
}
let sortedNormal = numbers.sort(compareNumbers);
console.log(sorsortedNormalted); // [10, 20, 30, 40, 50]

//1-----------ternary conditional operator

function compareNumbersTernary(a, b) {
     let retVal = a < b ? -1 : 1;
     return retVal;
}

console.log(sorted); // [10, 20, 30, 40, 50]

//2------------ anonymouse function

let retValAnonymouse = function(a, b) {
     a < b ? -1 : 1;
    return retValAnonymouse;
}

console.log(sorted); // [10, 20, 30, 40, 50]

//3------------ arrow function

let retVal = (a, b) => a < b ? -1 : 1;

let sortedArrow = numbers.sort(retVal);
console.log(sortedArrow); // [10, 20, 30, 40, 50]

//4---------------- compressed arrow function

let sortedComp = numbers.sort(retVal = (a, b) => a < b ? -1 : 1);
console.log(sortedComp); // [10, 20, 30, 40, 50]

//cisco answer ?? like what ???
let number = prompt("Enter a random number");
if(number > 90 && number < 110) {
    alert("Bingo!");
} else {
    alert("Miss");
}

//5-----------I will try to combine their odd answer and my stuff
let numberCombination = prompt("Enter a random number between 1-110");
let answer = (numberCombination > 90 && numberCombination < 110) ? alert("Bingo!"): alert("Miss");
 

numbers.push(Number(numberCombination)); //this pushes the number in as a string, and needs to be converted to an integer
let sorted = numbers.sort(retVal = (a, b)=>{return b-a;});

console.log(sorted, "," , numberCombination[0]); // [10, 20, 30, 40, 50], ?? should be the highest number


// //4.1.12
/* Familiarize the student with:

    loops (what are loops, the while loop, the do–while loop, the for loop, the for–of loop, the for–in loop, the break and continue statements)

Scenario

We can improve our contact list program a bit by using loops. You can now try to display not only the first or last contact, but all contacts in the list, regardless of their number.

Additionally, try to enclose the whole program in a loop so that the user is repeatedly asked what they want to do. The user can choose to:

    display the first contact (first)
    display the last contact (last)
    display all contacts (all)
    add a new contact (new)
    exit the program (quit)

After executing the selected action, the program will give the opportunity to choose again. The program should end the actions only after the user gives a specified command, for example quit. */

// let contacts = [{
//     name: "Maxwell Wright",
//     phone: "(0191) 719 6495",
//     email: "Curabitur.egestas.nunc@nonummyac.co.uk"
//     }, {
//     name: "Raja Villarreal",
//     phone: "0866 398 2895",
//     email: "posuere.vulputate@sed.com"
//     }, {
//     name: "Helen Richards",
//     phone: "0800 1111",
//     email: "libero@convallis.edu"
//     }];

// let continueInput = true;
// // let continueInput = userAction == 5 ? false : true;


// do{
//     let userAction = prompt("What do you want to do 1) Display the first contact, 2) Display the last contact, 3) Display all contacts, 4)Add new contact or 5)Stop here?", 0);
    
//     switch (userAction){
//         case userAction = "1": 
//         alert(`The current first contact is: ${contacts[0].name}`);
//         break;

//         case userAction = "2":
//         let lastConact = contacts.length - 1;
//         alert(`Current the last contact is: ${contacts[lastConact].name}`);
//         break;
        
//         case userAction = "3":
//             let list = "";
//             let count = 1;
//             contacts.forEach(contact => {
//                 list += ' ' + count + '. ' + contact.name + '\n';
//                 count++;
//             });

//         alert(`Your contacts \n${list}`); 
//         // for( let name in contacts) { console.log(`${name} -> ${contacts[name]}`);};
//         // alert (`Your contacts \n${contacts.name}`);
//         break;
   
//         case userAction = "4":
//         let contact = {};
//         contact.name = prompt("write your name:", "");
//         contact.phone = prompt("Write your phone number:", "");
//         contact.email = prompt("Write you email:", "");
//         if (contact.name !== "" || contact.phone !== "" || contact.email !== "") { contacts.push(contact);
//         } else { alert("Error. Contact information is missing")};
//         break;
        
//         case userAction = "5":
//         continueInput = false;
//         break;
        
//         default: alert("Error. It seem like your input is incorrect");
//     }
// } while (continueInput !==false);

// alert("Tak for denne gang");

// console.log("check", )

// //Exercise 6: Modify the calculator program that you made in Module 4 Section 2 in such a way that it will work in the loop until the user inputs Q in any of the prompt boxes.

// //4.1.11.6

// let numberOne = prompt("Input first number", 0);
// let operator = prompt("Choose one of the four mathematical operation  +, -, * or /","");
// let numberTwo = prompt("Input second number", 0);
// let numberCheck = Number.isNaN(numberOne) == false && Number.isNaN(numberTwo) == false ? true : false;
// let result;
// let input = true;

// if ( numberOne === "Q" || operator === "Q" || numberTwo === "Q" ){ input = false;}

// while(input == true){

// if (numberCheck == true){
//     switch (operator) 
//     { 
//         case operator = "+": 
//         result = numberOne + numberTwo;
//         alert(`Your result is: ${result}`);
//         break;

//         case operator = "-": 
//         result = numberOne - numberTwo;  
//         alert(`Your result is: ${result}`);
//         break;

//         case operator = "*": 
//         result = numberOne * numberTwo;
//         alert(`Your result is: ${result}`);
//         break;

//         case operator = "/": 
//         result = numberOne / numberTwo;
//         alert(`Your result is: ${result}`);

//         break;
//         default: alert("Error. The operator input is wrong");
//     }
// } else { alert("Error. Please ender a number");}
// alert("Your result is:", result);
// }

// alert("Error. Your entry is invalid");
// console.log("Satus for varables",check, operator, result);

//4.1.11.5

// let vessel = {
//     LATITUDE: "40.07288",
//     LONGITUDE: "154.48535", 
//     COURSE: "285.6", 
//     SPEED: "14.0", 
//     IMO: "9175717", 
//     NAME: "MARENO"
// };
 
// for( let key in vessel) { 
// console.log(`${key} -> ${vessel[key]}`);
// };

// console.log("check", vessel, vessel.Name);


//4.1.11.4
/*Exercise 4: Write a program using a loop that will ask the user for the name of the movie (first prompt) and its rating from www.imdb.com (second prompt). 
The program will allow you to enter as many movies as you want into the movies array. 
Each element of the array will be an object, consisting of two fields: title and imdb. The input is completed if the user presses Cancel in the prompt dialog. 
Then the program should first print out to the console all movies that have a rating of less than 7, then those whose rating is greater than or equal to 7. 
Write the name of the movie and its rating next to each other, e.g.: */

// let filmListExample = [
    //{title: "V for Vendetta" , rating: 8.2},
    //{title: "My Fault", rating: 6.2},
    //{title: "Promising Young Woman", rating: 7.5},
    //{title: "The Garfield Movie ", rating: 5.8},
    //{title: "Wasabi", rating: 6.6},
    //{title: "Saltburn", rating: 7.0},
    //{title: "The Accountant", rating: 7.3},
    //{title: "Howl's Moving Castle", rating: 8.3},
    // ];

// let filmList = [
    //     {title: "V for Vendetta" , rating: 8.2},
    //     {title: "My Fault", rating: 6.2}
    // ];

// let film = {};
// let finished = false;
// let lowRatingFilm = [];
// let highRatingFilm = [];

// while (finished !== true){
//     film.title = prompt("Add a movie title", "");
//     film.rating = prompt("Look into rating for the film on IMDB and add it here", "");

//    if ( film.title !== "" && film.rating !== ""){ filmList.push(film.title && film.rating);}

//    let continueLoop = confirm(`You have adeed ${filmList.length} films, Do you want to continue?`); 
//    finished = continueLoop === true ? false : true; 
// }

// for ( i = 0; i<filmList[filmList.length]; i++ ){
//     if (Number(filmList[i].film.rating) > 7.0){ continue; }
//     // console.log("The film number", filmList[i], filmList[i].title, filmList[i].rating);
//     highRatingFilm.push(film.title && film.rating);
// }

// for ( i = 0; i<filmList[filmList.length]; i++ ){
//     if (Number(filmList[i].film.rating) < 7.0){ continue; }
//     // console.log("The film number", filmList[i], filmList[i].title, filmList[i].rating);
//     lowRatingFilm.push(film.title && film.rating);
// }

// console.log(" Here is list of low rating", lowRatingFilm);
// console.log(" Here is list of high rating", highRatingFilm);
// console.log("The film list total number is:", filmList.length);

/*
//4.1.11.3

Exercise 3: There are ten different numbers in the following numbers array:
let numbers = [21, 45, 100, 12, 11, 78, 61, 4, 39, 22];

Write a program that first writes out all these numbers on the console, 
then only those that are even (hint: the remainder of dividing an even number by 2 is equal to 0), 
then only those that are larger than 10 and at the same time smaller than 60. */

// let numbers = [21, 45, 100, 12, 11, 78, 61, 4, 39, 22];
// let count = 0;

// while (count <=3)
// {
//     switch(count)
//     {
//         case 1:
//         for( let i = 0; i < numbers.length; i++){
//             console.log("The ledger contains number", numbers[i]);}
//         break;

//         case 2:
//         for (let i = 0; i < numbers.length; i++) {
//             if (i%2 == 0) { continue; }
//             console.log("The ledger contains number", numbers[i]);}
//         break;

//         case 3: 
//         for(let i = 0; i < numbers.length; i++){
//             if (10<i<60){console.log("The ledger contains number", numbers[i]);}}  
//         break;

//         default: alert("Now it is over");
//     }

//     count += 1;
//     console.log("status", count);
// }


// //4.1.11.2
        // //Exercise 2: Modify the previous program so that it asks the user for the first and last number it uses instead of 100 and 0 
        // //(hint: use the prompt dialog).

        // let start = prompt("Start point of counting down","");
        // let finish = prompt("Endpoint of countdown","");

        // console.log(start,finish);
        // if(Number(finish) < Number(start)){
        //    for (let i = start; i > finish; i -=10){
        //        console.log("Current count", i, "the start is", start);
        //    }
        //    alert(`We finished at ${finish}`);

        // } else { alert("Error. The start should be higher then finish number.")}


        // //  let start = prompt("Start point of counting down","");
        // //  let finish = prompt("Endpoint of countdown","");

        // //  console.log(start,finish);
        // //  if(Number(finish) < Number(start)){
        // //     for (let i = start; i > finish; i --){
        // //         console.log(i);
        // //     }
        // //     alert(`We finished at ${finish}`);
        // //  } else { alert("Error. The start should be higher then finish number.")}


        // // let start = prompt("Please enter what number you would like to start the count at","");
        // // let finish = prompt("Please enter what number you would like to finish the count at","");

        // // if(finish>start){
        // // for (let i=start; i> finish; i ++ ){
        // //     console.log(i);
        // //  }
        // // } else { alert("Error. The start should be less then finish number.")}



//4.1.11.1

// //do...while loop. it starts to print at 90.
// let i = 100;
// do {
//     i -= 10;
//     console.log(i);
// } while(i >0);

// //with while loop. it starts to print at 100.
// let i = 100;
// while (i >0 ){
//     // i -= 10;
//     console.log(i);
//     i = i - 10;
// }

//with - 10 in for loop. 
// for (let i=100; i>0; i -=10 ){
//     console.log(i);
// }

//with - 1 in for loop. The increment with 1 
// for (let i=100; i>0; i -- ){
//     console.log(i);
// }


// //4.0.9

/*During the last modification of the program with the contact list, 
we allow the user to add a new contact with the data entered by the user while the program is executing. 
Let's go a step further – try to modify the program so that the user has a choice of what they want to do with the list. 

They will have a choice of:
    showing the first contact (first)
    showing the last contact (last)
    adding a new contact (new)

When adding a new contact, check if the user has entered all the necessary data. 
If at least one of the three values is missing (name, phone, or email) don't add the contact. */


// let contacts = [{
//     name: "Maxwell Wright",
//     phone: "(0191) 719 6495",
//     email: "Curabitur.egestas.nunc@nonummyac.co.uk"
// }, {
//     name: "Raja Villarreal",
//     phone: "0866 398 2895",
//     email: "posuere.vulputate@sed.com"
// }, {
//     name: "Helen Richards",
//     phone: "0800 1111",
//     email: "libero@convallis.edu"
// }];

// let contact = {};
// let userChoice = prompt("Input an option number: 1)Add a new contact, 2)See the first contact or 3)See the last contact", 0);


// if (userChoice != "")
// {
//     switch (userChoice)
//     {
//         case "1":
//         contact.name = prompt("write your name:", "");
//         contact.phone = prompt("Write your phone number:", "");
//         contact.email = prompt("Write you email:", "");

//         if (contact.name !== "" && contact.phone !== "" && contact.email !== "")
//         { contacts.push(contact);
//         } else { alert("Error. You are missing input when adding a contact");}
//         break;

//         case "2":
//         alert(`The current first contact is: ${contacts[0].name}`);
//         break;

//         case "3":
//         let lastConact = contacts.length - 1;
//         alert(`Current the last contact is: ${contacts[lastConact].name}`);
//         break;

//         default: 
//         alert("Error. You need to choose an option number between 1-3");
//     }

// } else {alert ("Error. The choice is not valid.");}

// console.log("Status:", userChoice, contacts[0].name, contact);

// /* 
//     4.0.8.3
//         Exercise 3: Write a simple calculator application.
//         Ask the user for the following input, one by one: two numbers and a character representing a mathematical operation, one of "+", "-", "*", "/". 
//         If the user input is valid, calculate the result and show it to the user. 
//         If the user input is invalid, display a message that informs the user that an error has occurred.

//         Remember that the value returned by the prompt function is of the type string. 
//         You can use the Number.isNaN method to check if you get the correct number after conversion. 
//         For example, calling Number.isNaN(10) will return false, while Number.isNaN(NaN) will return true. */


//         let numberOne = prompt("Input first number", 0);
//         let operator = prompt("Choose one of the four mathematical operation  +, -, * or /","");
//         let numberTwo = prompt("Input second number", 0);

//         let check = Number.isNaN(numberOne) == false && Number.isNaN(numberTwo) == false ? true : false;
//         let result;


//         if( check == true)
//         {
//             switch (operator) 
//             { 
//                 case operator = "+": 
//                     result = numberOne + numberTwo;
//                     alert(`Your result is: ${result}`);
//                     break; 

//                 case operator = "-": 
//                     result = numberOne - numberTwo;  
//                     alert(`Your result is: ${result}`);
//                     break; 

//                 case operator = "*": 
//                     result = numberOne * numberTwo;
//                     alert(`Your result is: ${result}`);  
//                     break; 

//                 case operator = "/": 
//                     result = numberOne / numberTwo;
//                     alert(`Your result is: ${result}`);

//                     break;

//                 default: alert("Error. The operator input is wrong");       
//             }   
//         }
//         else 
//         {
//             alert("Error. Please provide a number for both entries");
//         }


//         console.log("Satus for varables",check, operator, result);



    //4.0.8.2

        // use prompt and do not give the number yourself.
        // let number = prompt("Inset number",0)
        // let message = 90 < number <110 ? alert("Bingo!") : alert("Miss!");
        // console.log(message);

    //4.0.8.1

        // // prompt not confirm
        // let number = confirm("Chose a number between 50 and 120",0);
        // if (number >90 || number <110){
        //     alert("Bingo!");
        // } else { alert("Miss!")};

    //3.2.6
        // let contacts = [{
        //     name: "Maxwell Wright",
        //     phone: "(0191) 719 6495",
        //     email: "Curabitur.egestas.nunc@nonummyac.co.uk"
        //     }, {
        //     name: "Raja Villarreal",
        //     phone: "0866 398 2895",
        //     email: "posuere.vulputate@sed.com"
        //     }, {
        //     name: "Helen Richards",
        //     phone: "0800 1111",
        //     email: "libero@convallis.edu"
        //     }];
            
        //     // write your code here
            
        //     let name = window.prompt("What is your name?", "name");
        //     let phone = window.prompt("What is your phone number?", 0);
        //     let email = window.prompt("What is your email?", "email@email.com");

        //     let decision =  window.confirm(`This is the information you have provided  ${name}, ${phone}, ${email}. Is it Okay?`);

        //     let contact = {
        //         name: name,
        //         phone: phone,
        //         email: email
        //     };

        //     contacts.push(contact);

        //     let last = contacts.length - 1;
        //         alert(`You been added successfully added with index  ${last}`);

        //     console.log(`${contacts[0].name} / ${contacts[0].phone} / ${contacts[0].email}`);
        //     console.log(`${contacts[last].name} / ${contacts[last].phone} / ${contacts[last].email}`);


    // // 3.2.5 //Dialogue Dialog box
        // let height = window.prompt("Choose a hight for a box?", 0);
        // // height = height ? height : "anonymous";
        // let width = window.prompt("Choose a hight for a box?", 0);
        // // width = width ? width : "anonymous";
        // let length = window.prompt("Choose a hight for a box?", 0);
        // // length = length ? length : "anonymous";
        // let boxVolume = length * width * height;
        // // alert("Your choice of", hight, width, "and", length, ". This makes your box ",  boxVolume ,  " volume.");
        // alert(`Calculated box volume is ${boxVolume}`);


    // 3.2.3 Dialogue Dialog box
        // alert("Hello, World!")
        // window.alert("Hello, World! for the second time");
        // alert(4 * 7);
        // alert(true);
        // alert("text 1", "text 2"); // only "text 1" will be displayed
        // let decision = window.confirm("Is it OK?");
        // console.log(decision);
        // let remove = confirm("Remove all data?");
        // let message = remove ? "Deleting Data" : "Cancelled"
        // console.log(message);
        // let name = window.prompt("What is your name?", "John Doe");
        // name = name ? name : "anonymous";
        // let age = prompt("Hello " + name + " how old are you?");
        // alert(name + " is " + age + " years old");

    //3.0.10.3

        //wrong answer
        // console.log(true && false);  
        // console.log(false && false);  
        // console.log(false && false || true);  
        // console.log(true && false || false && true);


    //3.0.10.2

        //comparison operators
        // console.log(4 * 5 === 20); //true
        // console.log(6 * 5 == "30"); //true
        // console.log(-17 < 0);   //true
        // console.log(25 > 1);  //true
        // console.log(2 + 2 * 2 != 4); //true

    //3.0.10.1
        // console.log(2 * 3 + 1);      // expected 7  
        // console.log(2 ** 4);          // expected 16  
        // console.log(5 * 1);          // expected 5  
        // console.log(8 ** 2 - 5 ** 2);   // expected 39

    //2.3.4

        // "use strict";
        // const prefix = "username_";
        // let userName = "Jack";
        // // const userName = "Adam";
        // // let prefixedUserName;
        // // const prefixedUserName;
        // // userName = "John";
        // prefixedUserName = prefix + userName;
        
        // console.log(prefixedUserName /*+ prefixedUserName2*/);
        // // console.log(prefixedUserName2);

    //2.2.5
        // let contacts = [{
        //     name: "Maxwell Wright",
        //     phone: "(0191) 719 6495",
        //     email: "Curabitur.egestas.nunc@nonummyac.co.uk"
        //     }, {
        //     name: "Raja Villarreal",
        //     phone: "0866 398 2895",
        //     email: "posuere.vulputate@sed.com"
        //     }, {
        //     name: "Helen Richards",
        //     phone: "0800 1111",
        //     email: "libero@convallis.edu"
        //     }];
            
        //     let contact = {
        //         name: "Maisie Haley",
        //         phone: "0913 531 3030",
        //         email: "risus.Quisque@urna.ca"
        //     };
            
        //     let listSize = contacts.length;
            
        //     contacts.push(contact);
        //     console.log("The full list is this long:", listSize);
        //     console.log("The full list is:", contacts);
        //     console.log("The first student on the list is", contacts[0].name, "and the last is", contacts[listSize].name);

    //2.2.3.6

        // let books = [
        //     {
        //         title: "Speaking JavaScript",
        //         author: "Axel Rauschmayer",
        //         pages: 460
        //     },
        //     {
        //         title: "Programming JavaScript Applications",
        //         author: "Eric Elliott",
        //         pages: 254

        //     },
        //     {
        //         title: "Understanding ECMAScript 6",
        //         author: "Nicholas C. Zakas",
        //         pages: 352

        //     },
        //     {  title: "Learning JavaScript Design Patterns",
        //        author: "Addy Osmani",
        //        pages: 254

        //     }
        // ];

        // books.shift();

        // console.log(`The length of the book collection is: ${books.length}`);
        // console.log(`The current book collection is as follows:`, books);

    //2.2.3.7
            // let sum = books[0].pages + books[1].pages + books[2].pages;
            // console.log(`pages: ${sum}`);


    //2.1.11.6
            // const str1 = 42 + + "1";
            // console.log(str1, "43");



    //2.2.3.5
        // let books = [
        //     {
        //         title: "Speaking JavaScript",
        //         author: "Axel Rauschmayer",
        //         pages: 460
        //     },
        //     {
        //         title: "Programming JavaScript Applications",
        //         author: "Eric Elliott",
        //         pages: 254

        //     },
        //     {
        //         title: "Understanding ECMAScript 6",
        //         author: "Nicholas C. Zakas",
        //         pages: 352

        //     }
        // ];

        // let borrowedBooks = books.splice(-2);
        // console.log(`The length of the book collection is: ${books.length}`);
        // console.log(`The amount of borrowed books is: ${borrowedBooks.length}`);
        // console.log("Borrowed books", borrowedBooks);

    //2.2.3.4

        // let books = [
        //     {
        //         title: "Speaking JavaScript",
        //         author: "Axel Rauschmayer",
        //         pages: 460
        //     },
        //     {
        //         title: "Programming JavaScript Applications",
        //         author: "Eric Elliott",
        //         pages: 254

        //     },
        //     {
        //         title: "Understanding ECMAScript 6",
        //         author: "Nicholas C. Zakas",
        //         pages: 352

        //     }
        // ];

        // let book = {
        //     title: "Learning JavaScript Design Patterns",
        //     author: "Addy Osmani",
        //     pages: 254
        // };

        // books.push(book);
        // console.log(`The length of the book collection is: ${books.length}`);
        // console.log("books", books);

    //2.2.3.2

        // let persons = {};

        // persons.name = "Lily";
        // persons.surname = "Lu";

        // console.log(`Name: ${persons.name}`);
        // console.log(`Surname: ${persons.surname}`);


    //2.2.3.1

        // let ticket = {
        //     from: bigcity,
        //     to: smallcity,
        //     price: 10
        // };


        // console.log("the ticket", ticket);

        // console.log(`Ticket from: ${ticket.from}`);
        // console.log(`Ticket to: ${ticket.to}`);
        // console.log(`Ticket price: ${ticket.price}`);



    //2.1.11.4
        // let s1 = "Hello";
        // let s2 = "World";
        // let s = s1 + s2;

        // let n1 = 4;
        // let n2 = 2;
        // let n = n1 + n2;

        // let b1 = true;
        // let b2 = false;
        // let b = b1+b2;

        // let bi1 = 11n;
        // let bi2 = 22n;
        // let bi = bi1+bi2;

        // let u1 = undefined;

        // console.log(`${s} [${typeof s }]`);
        // console.log(`${n} [${typeof n }]`);
        // console.log(`${b} [${typeof b }]`);
        // console.log(`${bi} [${typeof bi }]`);
        // console.log(`${u1} [${typeof u1 }]`);

    //2.1.11.4
        // let s1 = "Hello";
        // let s2 = "World";
        // let s = s1 + s2;

        // let n1 = 4;
        // let n2 = 2;
        // let n = n1 + n2;

        // let b1 = true;
        // let b2 = false;
        // let b = b1+b2;

        // let bi1 = 11n;
        // let bi2 = 22n;
        // let bi = bi1+bi2;

        // let u1 = undefined;

        // console.log(`${s} [${typeof s }]`);
        // console.log(`${n} [${typeof n }]`);
        // console.log(`${b} [${typeof b }]`);
        // console.log(`${bi} [${typeof bi }]`);
        // console.log(`${u1} [${typeof u1 }]`);


    //2.1.11.3
            // let string1 = "1234";
            // let number1 = Number(string1);
            // let bigint1 = BigInt(number1);
            // let boolean1 = Boolean(bigint1);

            // console.log("string:", string1);
            // console.log("number:", number1);
            // console.log("bigint:", bigint1);
            // console.log("bool:", boolean1);



    //2.1.11.2
            // let var1 = "test";
            // let var2 = 42;
            // let var3 = true;
            // let var4 = "***";
            // let var5 = "200";
            // let var6 = "20 345 56";
            // let var7 = null;
            // let var8 = 1n;
            // let var9 = "deja vu, deja su, deja vacu";
            // let var10 = undefined;
            // let var11 = NaN;
            // let var12 = 0;
            // let var13 = "";
            // let var14 = 2.3;

            // let s1 = String(var1);
            // let n1 = Number(var2);
            // let b1 = Boolean(var3);
            // let bi1 = BigInt(var8);
            // let u1 = var10;

            // console.log(`${var1} [${typeof var1}]`);
            // console.log(`${s1} [${typeof s1}]`);

            // console.log(`${var2} [${typeof var2}]`);
            // console.log(`${n1} [${typeof n1}]`);

            // console.log(`${var3} [${typeof var3}]`);
            // console.log(`${b1} [${typeof b1}]`);

            // console.log(`${var8} [${typeof var8}]`);
            // console.log(`${bi1} [${typeof bi1}]`);

            // console.log(`${u1} [${typeof u1}]`);


    //2.1.11.1
            // let var1 = "test";
            // let var2 = 42;
            // let var3 = true;
            // let var4 = "***";
            // let var5 = "200";
            // let var6 = "20 345 56";
            // let var7 = null;
            // let var8 = 1n;
            // let var9 = "deja vu, deja su, deja vacu";
            // let var10 = undefined;
            // let var11 = NaN;
            // let var12 = 0;
            // let var13 = "";
            // let var14 = 2.3;


            // let s1 = String(var1);
            // let n1 = Number(var2);
            // let b1 = Boolean(var3);
            // let bi1 = BigInt(var8);
            // let u1 = var10;

            // console.log("String:", s1);
            // console.log("Number:", n1);
            // console.log("Bool:", b1);
            // console.log("Big Interger:", bi1);
            // console.log("Undefined:", u1);

     //2.1.11.0
            // let var1 = "test";
            // let var2 = 42;
            // let var3 = true;
            // let var4 = "***";
            // let var5 = "200";
            // let var6 = "20 345 56";
            // let var7 = null;
            // let var8 = 1n;
            // let var9 = "deja vu, deja su, deja vacu";
            // let var10 = undefined;
            // let var11 = NaN;
            // let var12 = 0;
            // let var13 = "";
            // let var14 = 2.3;


            // let s1 = String(var1);
            // let s2 = String(var2);
            // let s3 = String(var3);
            // let s4 = String(var4);
            // let s5 = String(var5);
            // let s6 = String(var6);
            // let s7 = String(var7);
            // let s8 = String(var8);
            // let s9 = String(var9);
            // let s10 = String(var10);
            // let s11 = String(var11);
            // let s12 = String(var12);
            // let s13 = String(var13);
            // let s14 = String(var14);
            // let s15 = String(var15);

            // console.log("var1:", s1);
            // console.log("var2:", s2);
            // console.log("var3:", s3);
            // console.log("var4:", s4);
            // console.log("var5:", s5);
            // console.log("var6:", s6);
            // console.log("var7:", s7);
            // console.log("var8:", s8);
            // console.log("var9:", s9);
            // console.log("var10:", s10);
            // console.log("var11:", s11);
            // console.log("var12:", s12);
            // console.log("var13:", s13);
            // console.log("var14:", s14);
            // console.log("var15:", s15);


    //2.0.15.0
            // const contactNameOne = "Maxwell Wright";
            // const contactNameTwo = "Raja Villarreal";
            // const contactNameThree = "Helen Richards";

            // let contactPhoneOne = "(0191)719 6495";
            // let contactPhoneTwo = "0866 398 2895";
            // let contactPhoneThree = "0800 1111";

            // let contactEmailOne = "Curabitur.egestas.nunc@nonummyac.co.uk";
            // let contactEmailTwo = "posuere.vulputate@sed.com";
            // let contactEmailThree = "libero@convallis.edu";

            // console.log("Contact One:", "name:", contactNameOne, ", phone:", contactPhoneOne,", email:", contactEmailOne );
            // console.log("Contact Two:", "name:", contactNameTwo, ", phone:", contactPhoneTwo,", email:", contactEmailTwo);
            // console.log("Contact Three:", "name:", contactNameThree, ", phone:", contactPhoneThree,", email:", contactEmailThree);


    //2.0.14.2
            // const rosePrice = 8;
            // const lilyPrice = 10;
            // const tulipPrice = 2;

            // let numberOfRosesChnage = 20;
            // let numberOfLiliesChange = 0;
            // let numberOfTulipsChnage = 50;

            // let numberOfRoses = 70;
            // let numberOfLilies = 50;
            // let numberOfTulips = 120;

            // let rosesValue = rosePrice * numberOfRoses;
            // let liliesValue = lilyPrice * numberOfLilies;
            // let tulipsValue = tulipPrice * numberOfTulips;

            // let total = rosesValue + liliesValue + tulipsValue;
            // console.log("Rose - unit price:", rosePrice, ", quantity:", numberOfRoses - numberOfRosesChnage, ", value:", rosesValue);
            // console.log("Lily - unit price:", lilyPrice, ", quantity:", numberOfLilies - numberOfLiliesChange, ", value:", liliesValue);
            // console.log("Tulip - unit price:", tulipPrice, ", quantity:", numberOfTulips - numberOfTulipsChnage, ", value:", tulipsValue);
            // console.log("Total: ", total);

    //2.0.14.1
            // const rosePrice = 8;
            // const lilyPrice = 10;
            // const tulipPrice = 2;

            // let roseUnit = 70;
            // let lilyUnit = 50;
            // let tulipUnit = 120;


            // function testFunction() {
            //    roseValue = rosePrice * roseUnit;
            //    lilyValue = lilyPrice * lilyUnit ;
            //    tulipValue = tulipPrice * tulipUnit;

            //    totalValue = roseValue + lilyValue + tulipValue;
            // }
            
            // testFunction();
            

            // console.log(roseValue);
            // console.log(lilyValue);
            // console.log(tulipValue);
            // console.log(totalValue);


