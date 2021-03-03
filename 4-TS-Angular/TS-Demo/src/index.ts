//                     annotations
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

//let superHeros=['Batman','Spiderman','Avnegers'];
//superHeros.push('Thor');
//superHeros.push(10);

let mixedValues=['Thor',10,'Batman',25];
mixedValues.push(45);
mixedValues.push('Ironman');
mixedValues[0]=67;

//console.log(mixedValues[0])

// Tuple
let superHero:[string, number];//declare a tuple with 2 types
superHero=["Batman",25];//initialize
//superHero=[25,"Batman"];//error
console.log(superHero[0].substring(1));

// Unknown - dynamic value at compile time 
let data:unknown=4;
data="Harry Potter";
data=true;

//data.IsFixed();

declare const info:unknown;
//const aNum:number=info;


// Explicit types - annotations
let character:string="Spiderman";
let age:number;
let isSuperHero:boolean;

//age='batman';// error
age=30;

// Arrays of explict types
let superHeros:string[]=[];// declare and initialise empty
superHeros.push('Batman');
superHeros.push('ironman');
console.log(superHeros);

// Union Types
let userId: string|number;
userId="Pushpinder";
userId=2578;

//union types with arrays
type myType=string|number|boolean|object;
let mySuperHero:(myType)[]=[];
mySuperHero.push('Batman');
mySuperHero.push(30);
mySuperHero.push(true);
mySuperHero.push({name:'power',intesity:30});// added anonymous object
console.log(mySuperHero);

// objects
let mySuperHero1:object;//declaration
mySuperHero1={workName:'Spiderman',realName:'Peter Parker', age:27};

// creating a general object
let mySuperHeroObj:{
    workname:string,
    realname:string,
    age:number
};

// Any - dynamic value at runtime
let superHeroAge:any=25;
console.log(superHeroAge);
superHeroAge='25';
console.log(superHeroAge);
superHeroAge=true;
//superHeroAge.IsFixed();
console.log(superHeroAge);

let mixedValue:any[]=[];
mixedValue.push(25);
mixedValue.push('25');
mixedValue.push(true);
console.log(mixedValue);

