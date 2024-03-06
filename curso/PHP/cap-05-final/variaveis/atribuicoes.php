<div class="titulo">Atribuições</div>

<?php

$title = 'Atribuições';
$numero = 10;
echo '<br>' .$numero;
$numero--; //numero -1
echo '<br>' .$numero;
++$numero; //numero +1
echo '<br>' . $numero;
$numero = 20;
echo '<br>' . $numero;
$numero -= 5;
echo '<br>' . $numero;
$numero **= 7;
echo '<br>' . $numero;

$texto = 'Esse é um texto';
echo '<br>' .$texto;
$texto = $texto . ' qualquer';
echo '<br>' . $texto;

//$valorInexistente = 'valor Existente';
echo '<br>' . $valorInexistente;
$valor = $valorInexistente ?? 'valor default';
echo '<br>' . $valor;

