const escola = "cod3r";

//charAt(4) estou pedindo para ele me dar a 4 letra da variavel escola
console.log(escola.charAt(4));

//.charCodeAt(3) estou puxando o valor da tabela ASCII
console.log(escola.charCodeAt(3));

//.indexOf('3') oposto do charCodeAt
console.log(escola.indexOf('3'));

//.substring(1) vai imprimir do 1 pra frente
console.log(escola.substring(1));

//.substring(0, 3) ele vai do ince 0 e me de 3 caracter
console.log(escola.substring(0, 3));

//vc pode colocar algo literal na string com '' ou ""
console.log('Escola '.concat(escola).concat("!"));

//.replace(3, 'e') ele pego o indice 3 e substitui com o leteral que pedi no caso foi e
console.log(escola.replace(3, 'e'));


//vc pode pegar uma string que esta separada por , e transforma em um array
//.split(',') e colocar oq vc quer que seja o separador para ele transforma em uma array
console.log('Gabriel,Thaina,lucius'.split(','));


