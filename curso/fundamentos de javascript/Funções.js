//Funções sem retorno
function imprimirSoma(a, b){
    console.log(a + b);
}

imprimirSoma(2, 3);
imprimirSoma(2)

//Funções com retorno
function Soma(a, b=1){
    return a + b;
}
console.log(Soma(6, 3));
console.log(Soma(2))

//armazenando uma função em uma variavel
const imprimirSoma = function(a, b){
    console.log(a + b);
}

imprimirSoma(2, 3);

//armazenando uma função arrow em uma variavel
const soma = (a, b) =>{
    return a + b;
}

console.log(soma(2, 5));

//retorno implícito 
const subtracao = (a, b) => a-b;
console.log(subtracao(3, 2));