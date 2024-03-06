<div class="titulo">Tipo String</div>

<?php

echo 'Eu sou uma String';
echo '<br>';
var_dump("Eu também");

echo '<br>';

//concatenação

echo "Nos tambem" . ' somos';

echo '<br>', "tambem aceito", " virgulas";

echo '<br>';

echo " 'Teste' " . ' " Teste" ' .  ' \' Teste\' ' .  " \"teste\" " ;

print("<br>tambem");
print "<br>Tambem";

//ALGUMAS FUNÇÕES

echo '<br>' . strtoupper('maximazdo');
echo '<br>' . strtolower('minimizado');
echo '<br>' . ucfirst('só a primeira letra');
echo '<br>' . ucwords('todas as palavras');
echo '<br>' . strlen('Quantas letras?');
echo '<br>' .  mb_strlen("Eu também", "utf-8");
echo '<br>' . substr('Só uma parte mesmo', 7,6);
echo '<br>' . str_replace('isso', 'aquilo', 'Trocar isso isso');