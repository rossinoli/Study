#include<stdio.h>
#define TAM 3
main(){
	int i,vet[TAM];
	
	//entrada
	for(i=0; i< TAM; i++){
		printf("\nDigite numero posicao %i:",i);
		fflush(stdin); scanf("%i",&vet[i]);
	}
	//processamento & Saida
	for(i =0; i< TAM; i++){
		if(vet[i]%2 == 0){
			printf("\n Num: %i | posicao: %i",vet[i],i);
		}
	}

	return 0;
}