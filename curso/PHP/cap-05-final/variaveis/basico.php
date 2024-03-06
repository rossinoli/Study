<div class="titulo">Variaveis</div>

<?php
//variavies php $nome da variavel
$numero = 13;
echo $numero, '<br>';
var_dump($numero);

echo '<br>';
$a = 3;
$b = 16;
$soma = $a + $b;
echo $soma;
echo '<br>';
echo isset($soma);


unset($soma);
echo '<br>';
var_dump($soma);

echo '<br>';
$variavel = 10;
echo '<br>' . $variavel;

$variavel = "Agora sou uma string!";
echo '<br>'. $variavel;

//atribuição por referencia 
//Para atribuir por referência, simplesmente adicione um e-comercial (&)
$foo = 'bob';
 $bar = &$foo;
 $bar = "My name is $bar";
 echo $bar;
 echo $foo;



 //Nomes de variaveis
 //$4site = 'not yet';      inválido; começa com um número
 $_4site = 'not yet';    // válido; começa com um sublinhado
 $täyte = 'mansikka';    // válido; 'ä' é um caracter ASCII (extendido) 228

 //variavies predefinidas Superglobais
/* versão 8.3
$GLOBALS
$_SERVER
$_GET
$_POST
$_FILES
$_COOKIE
$_SESSION
$_REQUEST
$_ENV
*/
