//exemplos de como var e let se comporta 

//Usando Var em Loop #01
/*
for (var i =0; i < 10; i++){
    console.log(i);
}
console.log('i=',i);
*/

//Usando Let em Loop #01
/*
for(let i =0; i < 10; i++){
    console.log(i);
}
console.log('i=', i);//da erro
*/

//Usando Var em Loop #02

const funcs1 =[];
for(var i=0; i<10;i++){
    funcs1.push(function(){
        console.log(i);
    })
}
funcs1[2]()
funcs1[8]()


//Usando Let em Loop #02

const funcs2 =[];
for(let i=0; i<10;i++){
    funcs2.push(function(){
        console.log(i);
    })
}
funcs2[2]()
funcs2[8]()
