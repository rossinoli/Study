const pessoa = {
    nome:'Ana',
    idade: 18,
    endereco:{
        logradouro: 'Rua ABC',
        numero: 1000
    }
}

//extrai o atributo nome e idade do objeto pessoa
const {nome, idade} = pessoa
console.log(nome, idade);

//extrai o atributo nome e criei a variavel n e extrai atributo idade e criei a variavel i do objeto pessoa
const {nome: n, idade: i} = pessoa
console.log(n,i)

//extrai o atributo logradouro e numero que esta dentro do endereco que esta dentro do pessoa
const {endereco: {logradouro, numero}} = pessoa
console.log(logradouro,numero);

/*objeto
function rand({min = 0, max = 1000}) {
    const valor = Math.random() * (max - min) +min
    return Math.floor(valor)
}
exemplo que varias forma de afetura a function
exemplo1
const obj = {max:20}
console.log(rand(obj))

exemplo2
console.log(rand({max:20, min:1})) */

/*array
function rand([min=0, max=1000]) {
    if (min > max) [min, max] = [max, min]
    const valor =  Math.random() * (max - min) + min
    return Math.floor(valor)
}

console.log(rand([20,1])) */