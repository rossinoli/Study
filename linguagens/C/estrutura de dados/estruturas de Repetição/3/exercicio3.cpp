#include<stdio.h>

main(){
		//entrada
	int i,soma=0;
		//processamento
	for (i=1; i<=1000; i++){
		if((i%2==0) && (i%5==0) && (i%7==0)){
			soma = soma + i;
		}
	}
		//saida
	printf("\n Soma: %i", soma);
	
	return 0;
}