<div class="titulo">Variaveis Variaveis</div>

<?php

$a = 'hello';
$$a = "world";
echo "$a {$$a} ${$a} $hello";

echo '<br>';
$epa ='opa';
$opa = 'vish';
$vish = 'eita';
echo "$epa {$$epa} {$$$epa}";
