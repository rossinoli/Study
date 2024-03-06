#include<stdio.h>

main(){
	int i,inverso,vet[10] ;
	//entrada
	for(i=0; i<10; i++){
		printf("\nDigite o valor da posicao %i:",i);
		fflush(stdin); scanf("%i",&vet[i]);
	}
	
	for(i =9; i>=0; i--){
		printf("\n posicao: %i  numero: %i", i,vet[i]);
	}
	
	
}