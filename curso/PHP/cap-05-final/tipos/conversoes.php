<div class="titulo">Conversões</div>

<?php

// int para float
echo '<p>Int para float</p>';
echo '<br>';
var_dump(PHP_INT_MAX + 1);
echo '<br>';
var_dump((int)"10.5");
echo '<br>';



//floar para int 
echo '<p>Float para int</p>';
var_dump((float)"10.5");
echo '<br>';
var_dump((int)6.8);
echo '<br>';
var_dump(intval(2.8));
echo '<br>';
var_dump((int)round(2.8));

echo '<br>';
//operações com string
echo '<p>Operaçãoes com string</p>';
var_dump(3 + "2");
echo '<br>';
var_dump("3" . 2);
echo '<br>' , is_string("3" . 2);
echo '<br>';
var_dump(1 + "5 cinco");



