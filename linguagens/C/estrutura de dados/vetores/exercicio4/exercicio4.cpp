#include <stdio.h>
#define TAM 3
/*
*	leia um vetor de 10 números e calcule a sua média aritmética. Na sequência mostre quantos números
*	estão abaixo da média, quantos são iguais à média e quantos estão acima da média.
*/

main(){
	int i, vet[TAM];
	printf("\n CALCULAR MEDIA \n");
	//Entrada
	for(i=0; i<TAM; i++){
		printf("\n Digite numero: ");
		fflush(stdin);scanf("%i",&vet[i]);
	}
	//Processamento && Saida
	for(i=0; i<TAM; i++){
			if(vet[i]>6){
		printf("\n maior que media: %i",i);
	}else if(vet[i]==6){
		printf("\n Igual media: %i",i);
	}else if(vet[i]<6){
		printf("\n menor que media: %i"),i;
	}
	}

}