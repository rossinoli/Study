#include<stdio.h>

main(){
	int i, num[10];
	//entrada
	for(i=0; i<10; i++){
		printf("\n Digite numero: ");
		fflush(stdin); scanf("%i",&num[i]);
	}
	
			printf("\n-----Posicao e Numero-----");
	for(i=0; i<8; i++){
		printf("\n posicao:%i numero:%i \n",i,num[i]);
	}
	
}