"use strict";
// FUNCTIONS
//  variable  function    function
//  holding   speci-      definition
//  function  fication
let greetings = () => console.log("Hello World"); //arrow function without and return value
// sgreetings='Hello'; //error
/*let greeting=function Hello(){
    console.log("Hello World");
}*/
const add = (a, b = 60) => a + b;
console.log(add(10));
