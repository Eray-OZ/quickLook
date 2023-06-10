console.log("Math.() İşlemleri");

// let a = 1.7;
// let b = 1.3;
// let c = 1.6;


// console.log("Sayı = 1.7 Aşağıya Yuvarlama: ",Math.floor(a));

// console.log("Sayı = 1.3 Yukarı Yuvarlama: ",Math.ceil(b));

// console.log("Sayı = 1.6 Yakına Yuvarlama: ",Math.round(a));


// let x = [1,2,3,4,5];
// let y = Math.max(...x)
// console.log(x,"listesinin Maksimumu: ",y);


// let z = 16;

// console.log("Karaekök ",z,"=",Math.sqrt(z));

// let v = Math.LN10;
// console.log(v);



console.log("\n\n\n\n\n\n\n\n");


























console.log("Tür Dönüşümü")



// let a ="10";
// console.log(typeof a)
// console.log(typeof parseInt(a));

// let b = 5;
// console.log(typeof toString(b));


// let c = 10.15;
// c = parseInt(c);
// console.log(c);


// let number = "11px";
// number = Number(number)
// console.log(number,typeof(number))

// let number2 = "11.4px";
// number2 = parseFloat(number2);
// console.log(number2, typeof number2);


// let x = 123;
// x = x + "";
// console.log(x, typeof(x));



console.log("\n\n\n\n\n\n\n\n");


























console.log("String İşlemleri");



// let email = "hakanyalcinkaya@gmail.com";



// console.log(email.search("@"));
// console.log(email[email.search("@")]);

// console.log(email.search(";")); // Olmayanları -1 Olarak Döner





// console.log(email.slice(0,15));
// console.log(email.slice(15));






// email = email.replace(email.slice(email.search("@")+1),"outlook.com");
// console.log(email);








// console.log(email.includes("@"));

// console.log(email.includes("asd"));









// let firstName = "hakan";
// let lastName = "YALCINKAYA";


// console.log(firstName.startsWith("hA"));

// console.log(lastName.endsWith("AYA"));










// firstName = `${firstName[0].toUpperCase()}${firstName.slice(1)}`;

// lastName = `${lastName[0]}${lastName.slice(1).toLowerCase()}`;

// console.log(firstName,lastName);



console.log("\n\n\n\n\n\n\n\n");










































console.log(`
DOM
--------------------------------------------------------
`)
console.log("\n");



// console.log(document.URL);

// console.log(document.location);

// console.log(document.location.pathname);

// console.log(document.body);

// console.log(document.head);


// document.body.style.backgroundColor = "aqua";





// let title = document.getElementById("title");

// title.innerHTML = "Hello World!";

// console.log(title.innerHTML)







// let link = document.querySelector("ul#list>li>a");

// link.innerHTML += " Changed"

// console.log(link.innerHTML)


// link.style.color = "red"
// link.classList.add("btn")





console.log("\n\n\n\n\n\n\n\n")


































console.log("Prompt")







// let fullName = prompt("Please enter a name")


// let title = document.getElementById("title")

// title.innerHTML = `<span style="color:red">Hello</span> ${fullName}!`




console.log("\n\n\n\n\n\n\n\n")






































console.log("HTML Element List")




// let last_item = document.querySelector("ul#listII>li:last-child")

// last_item.innerHTML = "Amazon"

// console.log(last_item)






// let ulDOM = document.querySelector("ul#listII")

// let liDOM = document.createElement("li")

// liDOM.innerHTML = "New Element"

// ulDOM.append(liDOM)





// let li2DOM = document.createElement("li")

// li2DOM.innerHTML = "New Element"

// ulDOM.prepend(li2DOM)



console.log("\n\n\n\n\n\n\n\n")

































console.log("CSS Class")




// let title = document.querySelector("#title");


// title.classList.add("text-primary");

// title.classList.add("title");
// title.classList.remove("title")

// console.log(title.classList)



console.log("\n\n\n\n\n\n\n\n")


































console.log("Ternary Operator");


// let userName = prompt("Name: ");
// let info = document.querySelector("#info");


// info.innerHTML = `${userName.length > 0 ? userName : "No Info :("}`

















console.log("Excersice")

// let hp = `<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-emoji-smile" viewBox="0 0 16 16">
// <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
// <path d="M4.285 9.567a.5.5 0 0 1 .683.183A3.498 3.498 0 0 0 8 11.5a3.498 3.498 0 0 0 3.032-1.75.5.5 0 1 1 .866.5A4.498 4.498 0 0 1 8 12.5a4.498 4.498 0 0 1-3.898-2.25.5.5 0 0 1 .183-.683zM7 6.5C7 7.328 6.552 8 6 8s-1-.672-1-1.5S5.448 5 6 5s1 .672 1 1.5zm4 0c0 .828-.448 1.5-1 1.5s-1-.672-1-1.5S9.448 5 10 5s1 .672 1 1.5z"/>
// </svg>`


// let sd = `<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-emoji-frown-fill" viewBox="0 0 16 16">
// <path d="M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zM7 6.5C7 7.328 6.552 8 6 8s-1-.672-1-1.5S5.448 5 6 5s1 .672 1 1.5zm-2.715 5.933a.5.5 0 0 1-.183-.683A4.498 4.498 0 0 1 8 9.5a4.5 4.5 0 0 1 3.898 2.25.5.5 0 0 1-.866.5A3.498 3.498 0 0 0 8 10.5a3.498 3.498 0 0 0-3.032 1.75.5.5 0 0 1-.683.183zM10 8c-.552 0-1-.672-1-1.5S9.448 5 10 5s1 .672 1 1.5S10.552 8 10 8z"/>
// </svg>`




// let note = prompt("Enter Note: ");


// let textInfo = hp;
// let info = document.querySelector("#info");


// if (note>=0 && note<=100)
// {
// info.innerHTML = `${
// note>=90  ? textInfo += " AA" : note>=85 ? textInfo += " BA" : note>=80 ? textInfo += " BB" : 
// note>=75 ? textInfo += " CB" : note>=70  ? textInfo += " CC" : note>=65 ? textInfo += " DC" :
// note>=60 ? textInfo += " DD" : note>=50 ? textInfo += " FD" :
// note>=0 ? textInfo =  sd + " FF" : "Geçersiz Not"}`;
// }
// else
//     alert("???")


// if (note>=0)
//     info.classList.add('text-danger');
// else
//     info.classList.add('text-primary');



















































console.log("Array");


// let domain = "kodluyoruz";
// let isActive = false;
// let items = [1, 2, 3, isActive, domain]; 

// console.log(items);
// document.querySelector("#info").innerHTML = items.length;

 

// console.log(Array.isArray(items));



// let newArr = [1, 2, 3, [4, 5, 6], 7, 8, 9];
// console.log(newArr);
// console.log(newArr[3]);
// console.log(newArr[3][0]);





console.log("Array Operations")

// let items = [10, 20, 30, 40, ]

// console.log(items)

// items.push(50)

// console.log(items)

// items.unshift(5)

// console.log(items)

// items.pop()

// console.log(items)

// items.shift()

// console.log(items)

// items[items.length-1] = 999

// console.log(items)

// items[900] = 1000

// console.log(items)







console.log("Array Methods")


let items = [1, 2, 3, 4, 5]

let femaleUsers = ["Ayşe", "Hülya", "Merve"]
let maleUsers = ["Ahmey", "Hasan", "Mehmet"]



items.unshift(femaleUsers)
items.push(maleUsers)

console.log(items)








 
