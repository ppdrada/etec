<html> 
<body bgcolor="#00ffcc">
	<h1 style="color:pink;"><b>MINHA TABUADA MALUQUINHA 	
<?php
$numero = $_GET['txtnumero'];
$contador = 0;

echo 'DO ' . $numero . '</b></h1><br>';

for ($contador = 0; $contador < 11; $contador++){
	echo $numero . '*' . $contador . '=' . ($contador*$numero) . '<br/>';	
}	
?>
</body>
</html>