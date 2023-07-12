const peso1 = 1.0;
const peso2 = Number('2.0');
console.log(peso1, peso2);
console.log(Number.isInteger(peso1));
//Number.isInteger determina se o valor passado é um inteiro.

const avaliacao1 = 9.871;
const avaliacao2 = 6.871;

const total = avaliacao1 * peso1 + avaliacao2 * peso2;

const media = total / (peso1 + peso2);
//toFixed dígitos que aparecem depois do ponto decimal
console.log(media.toFixed(3));
//toString converte valor numerico em string returnado em binario 
console.log(media.toString(2));
//typeof ver o tipo da variavel
console.log(typeof media);

