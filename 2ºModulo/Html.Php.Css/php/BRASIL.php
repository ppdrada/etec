<html>
	<head>
		<title></title>
		<meta charset="utf-8">
	</head>
	<body>

		<?php
			$conexao = mysqli_connect('localhost','root','1234','BRASIL');
			$cSQL = "insert into ESTADOS(STDUF,STDCIDADE,STDREGIAO,STDPOPULACAO) values('SP', 'São Paulo', 4, 20000000)";
            mysqli_query($conexao, $cSQL);		
		?>

		<form>
			<label>
				UF: <input type="text" name="txtUF" maxlength="2">
			</label>
			<br>
			<br>

			<label>
				Cidade: <input type="text" name="txtcidade">
			</label>
			<br>
			<br>

			<label>
				Capital: <input type="text" name="txtcapital">
			</label>

			<label>
				<select name="cmbRegiao">
					<?php
						echo '<option value ="0"> Selecione uma Região </option>';
						$cSQL = 'select RGSCODIGO,RGSNOME from REGIOES';
						$oTabela = mysqli_query($conexao,$cSQL);
						while($oReg = mysqli_fetch_assoc($oTabela))
						{
							echo '<option value = "' . $oReg['RGSCODIGO'] . '">' . $oReg['RGSNOME'] . '</option>';
						}
						mysqli_free_result($oTabela);
					?>
				</select>
			</label>
			<br>
			<br>

			<label>
  				População <input type="number" name="txtpopulacao">
			</label>
			<br>
			<br>
			<button>
				Gravar,Inserir, ou APERTE AQUI!!!!
			</button>
		</form>
		<table>
			<?php
            
			//	Aqui eu vou listar os Estados
            echo '<p>Estados:</p>';
            $cSQL = 'select STDUF,STDCIDADE,STDCAPITAL,STDREGIAO,STDPOPULACAO from ESTADOS';
			$Tabela = mysqli_query($conexao,$cSQL);
			while($oReg = mysqli_fetch_assoc($Tabela))
						{
							echo '<tr><td>' . $oReg['STDUF'] . '</td><td>' . $oReg['STDCIDADE'] . '</td><td>' . $oReg['STDCAPITAL'] . '</td><td>' . $oReg['STDREGIAO'] . '</td><td>' . $oReg['STDPOPULACAO'] . '</td></tr>';
				}
				mysqli_free_result($Tabela);
			mysqli_close($conexao);
			?>
		</table>
	</body>
</html>