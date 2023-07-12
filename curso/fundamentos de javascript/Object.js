const prod1 = {};
prod1.nome = 'Celular Ultra Mega';
prod1.preco = 4998,90;
prod1['Desconot Legal'] = 0.40; //evite atributos com espaço

console.log(prod1);

const prod2 = {
    nome:'Camisa Polo', 
    preco: 79.90,
    tipo: {
        tipo: 'Camisas Polo', 
        Marca: {
            Marca: 'Ralpn'
        }
    }
};

console.log(prod2);
