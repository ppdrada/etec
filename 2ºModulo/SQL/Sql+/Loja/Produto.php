<html>
	<head lang="pt-br">
		<meta charset="utf-8">
		<title></title>
		<style type="text/css">
		table{
			border: 2px solid black;
			height: 200px;
		}
		img{
			float: left;
			height: 200px;
			width:200px;
			text-align:center;
		}
		#txtNome{
			font-family: arial black;
			font-size: 20px;
		}
		#txtSubtProd{
			font-family: arial;
			font-style: italic;
		}
		#txtSubtProd{
			font-family: arial;
			font-size: 20px;
		}
		#txtSubtProd{
			font-family: arial;
			font-style: italic;
		}
		</style>
	</head>
	<body>
		<table>
			<?php
				$oConec = mysqli_connect("localhost","root","","Produtos");
 				mysqli_set_charset($oConec, 'utf8');
 				$oSql = "select * from ProdutoDaLoja";
				$oTabela = mysqli_query($oConec, $oSql);
				while($oReg=mysqli_fetch_array($oTabela))
				{
					echo '<tr><td>'.'<img src="'.$oReg['imgProd'].'"> </td><td id="txtNome">'. $oReg['NomeProd'].'</td><br><td  id="txtSubtProd">'. $oReg['SubtProd'].'</td><td  id="txtSubtProd">'.$oReg['DescricaoProd'].'</td><td  id="txtSubtProd"> R$ '.$oReg['PrecoProd'].'</td></tr>';
				}
				mysqli_free_result($oTabela);
				mysqli_close($oConec);
			?>
		</table>
	</body>

	<!--
		mysqli_connect: Conectar 
		mysqli_set_charset: Configurar a linguagem
		mysqli_query: Pesquisar
		mysqli_fetch_assoc: Retorna uma matriz associativa que corresponde a linha obtida e move o ponteiro interno dos dados adiante.   
		mysqli_fetch_array: Retorna uma matriz que corresponde a linha buscada
		mysqli_free_result: Liberar a memória
		mysqli_close: Fechar

	-->
</html>