<div class="titulo">Valor VS Referencia</div>

<?php
//Atribuição por VALOR
$variavel = 'valor inicial';
echo $variavel;

$variavelvalor = $variavel;
echo "<br> $variavelvalor";

$variavelvalor = 'novo valor';
echo "<br> $variavel  $variavelvalor";

//Atribuição por Referencia;
$variavelreferencia = &$variavel;
$variavelreferencia = 'mesma referencia';
echo "<br> $variavelreferencia  $variavel";