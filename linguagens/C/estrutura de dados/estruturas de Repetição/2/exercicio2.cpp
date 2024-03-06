#include<stdio.h>


main(){
	int idade;
	float media, soma=0, cont=0;

		//Entrada
	printf("\nDigite a Idade (ou zero p/ finalizar):");
	fflush(stdin); scanf("%i",&idade);
	while (idade>0){
		soma = soma + idade;
		cont++;
	printf("\nDigite a Idade (ou zero p/ finalizar):");
	fflush(stdin); scanf("%i",&idade);
	}
	
		//Processamento
	if (cont==0){
		media=0;
	}else{
		media = (float) soma/cont;
	}
	
		//saida
	printf("\nA idade media = %5.2f",media);
}



