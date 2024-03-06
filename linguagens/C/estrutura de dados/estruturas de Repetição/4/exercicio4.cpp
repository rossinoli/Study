#include<stdio.h>


main(){
	int num, i, resultado=0;
		//entrada
	printf("\nDigite um numero: ");
	fflush(stdin); scanf("%d",&num);
		//processamento
	for(i=2; i<=num / 2; i++){
		if (num % i ==0){
			resultado++;
		}
	}
		//saida
	if(resultado ==0){
		printf("%d Eh um numero primo\n",num);
	}else{
		printf("%d Nao eh um numero primo\n",num);
	}
	return 0;
}