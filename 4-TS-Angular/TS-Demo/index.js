//                     annoations
function Greetings(name) {
    return 'Hello ' + name;
}
console.log(Greetings('Pushpinder')); //(123));// error
// boolean
var isAvailable = true;
//isAvailable="Hello";// type checking gives error if string is assigned to boolean
//Arrays
var marks = [50, 70, 75, 90];
marks.push(76);
//marks.push('78');
var superHeros = ['Batman', 'Spiderman', 'Avnegers'];
superHeros.push('Thor');
//superHeros.push(10);
var mixedValues = ['Thor', 10, 'Batman', 25];
mixedValues.push(45);
mixedValues.push('Ironman');
mixedValues[0] = 67;
console.log(mixedValues[0]);
