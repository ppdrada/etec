<html>

<head>
  <meta charset="utf-8" />
</head>

<style>
*
{
  font-family: sans-serif;
}

TABLE
{
  width: 100%;
}

TH
{
  background: #000000;
  color: #FFFFFF;
}
</style>

<body>
  <table>
    <tr>
	  <th>Musica</th>
	  <th>Intérprete</th>
	</tr>
	
<?php
$oCon = mysqli_connect('localhost', 'root', '', 'ACERVO');

$nDisco = 0;
if (isset($_GET['txtDisco']))
  $nDisco = $_GET['txtDisco'];

if (!$oCon)
  die (mysqli_connect_error());

mysqli_set_charset($oCon, 'utf8');

$cSQL = "SELECT MSCNOME, IFNULL(ARTNOME, BDSNOME) INTERPRETE" .
        "  FROM DISCOS" .
		" INNER JOIN MUSICAS ON DSCCODIGO = MSCDISCO" .
		"  LEFT JOIN ARTISTAS ON DSCARTISTA = ARTCODIGO" .
		"  LEFT JOIN BANDAS ON DSCBANDA = BDSCODIGO" .
		" WHERE DSCCODIGO = 0" . $nDisco;
$oDados = mysqli_query($oCon, $cSQL);

while ($oReg = mysqli_fetch_assoc($oDados))
  echo '<tr><td>' . $oReg['MSCNOME'] . '</td><td>' . $oReg['INTERPRETE'] . '</td></tr>';

mysqli_free_result($oDados);
mysqli_close($oCon);
?>
</table>

</body>
</html>