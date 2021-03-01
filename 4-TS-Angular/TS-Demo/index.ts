//                     annoations
function Greetings(name:string){
    return 'Hello ' + name;
}
console.log(Greetings('Pushpinder'));//(123));// error

// boolean
let isAvailable = true;
//isAvailable="Hello";// type checking gives error if string is assigned to boolean

//Arrays
let marks=[50, 70, 75, 90];
marks.push(76);
//marks.push('78');

let superHeros=['Batman','Spiderman','Avnegers'];
superHeros.push('Thor');
//superHeros.push(10);

let mixedValues=['Thor',10,'Batman',25];
mixedValues.push(45);
mixedValues.push('Ironman');
mixedValues[0]=67;

console.log(mixedValues[0])