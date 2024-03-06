<div class="titulo">Constantes</div>

<?php
define('TAXA_DE_JUROS', 5.9);
echo TAXA_DE_JUROS;

const NOVA_TAXA = 2.5;
echo '<br>' . NOVA_TAXA;

$valorVariavel = 2.8;
//define('NOVISSIMA_TAXA',$valorVariavel);
const NOVISSIMA_TAXA = 2.8 + 1.2;
echo '<br>' . NOVISSIMA_TAXA;

//EXISTE CONSTANTES PREDEFINIDAS
/*
Essas constantes são definidas pelo núcleo do PHP. 
Isso inclui o PHP, o engine do Zend e módulos SAPI.
*/

//EXISTE CONSTENTES MAGICAS
/*
__LINE__ = O número da linha atual do arquivo.
__FILE__ = O caminho completo e o nome do arquivo com links simbólicos resolvidos. 
__DIR__ =  O diretório do arquivo. Se usada dentro de um include, o diretório do arquivo incluído será retornado.
__FUNCTION__ = 	O nome da função ou {closure} para funções anônimas.
__CLASS__ = O nome da classe. O nome da classe inclui o namespace em que foi declarada (por exemplo, Foo\Bar). 
__TRAIT__ = O nome do trait. O nome do trait inclui o namespace em que foi declarado (por exemplo, Foo\Bar).
__METHOD__ = O nome do método da classe.
__NAMESPACE__ = O nome do namespace atual.
ClassName::class = O nome totalmente qualificado da classe.
*/
