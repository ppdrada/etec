<html>
	<head>
		<title></title>
		<style>
			body { 

				background:linear-gradient(#00ba09 33%, #eaf700 70%, #1400f7 100%);
			}
			form{
				background-color: rgb(252, 248, 2, 0.7);
    			margin-top: 2em;
    			margin-left: 30%;
   				margin-right: 30%;
   				border: solid black 4px;
    			padding: 4em;
			}
			label{
				color:black;
				text-align: justify;
				font-family: sans-serif;
				line-height: 2;
			}

			h1{
				color:white;
				text-align: center;
				font-family: sans-serif;

			}
			p,th{
				color:black;
				text-align: justify;

				font-family: sans-serif;
				font-size: 20px;
				
				margin-top: 2em;
    			margin-left: 30%;
   				margin-right: 30%;
			}
			table,tr,td{
                background-color: floralwhite;
                
                border: solid black 4px;
				margin-top: 2em;
    			margin-left: 30%;
   				margin-right: 30%;
			}
            table{
                width: 40%;
                
            }
			#UF{
				margin-left: 8%;

			}
			#UFs{
				width:28px;
				
			}
			input{
				left:95px;
  				margin-top:2px;
  				width:225px;	
 				background: rgb(247, 247, 230, 0.5);
			}
			button{
				color:white;

				background: #00ba09;
				margin-left: 75%;
				margin-top: 6px;

			}
			select{
				background: rgb(247, 247, 230, 0.5);
				
			}
		</style>
		<meta charset="utf-8">
	</head>	
	<body>
		<?php
			$oConexao = mysqli_connect('localhost','root','quarterback5','Brasil');//<!--servidor, usuario, senha, banco de dados!-->
			// aqui eu vou gravar um estado;
			if(isset($_GET['UF']))
			{
        		$cSQL = "insert into estados(stdUF,stdCidade,stdCapital,stdRegiao,stdPopulacao) values('".$_GET[txtUF]."','" .$_GET[txtCidade]."','" .$_GET[txtCapital]."', '".$_GET[cmbRegiao]."','".$_GET[txtPopulacao]."')";
         		mysqli_query($oConexao, $cSQL);
        	}
        
		?>
		<br>
		<h1> Cadastre um Estados Brasileiro </h1>
		<form>
		
			<label>
				Cidade:  <input  name="txtCidade">
			</label>

			<label id='UF'>
				UF: <input id='UFs'  maxlength="2" name="txtUF">
			</label>

			<br>			

			<label>
				Capital: <input  name="txtCapital">
			</label>

			<br>

			<label>
				<select name = "cdmRegiao">
					<?php
					echo '<option value="0">Selecione uma região</option>';

						$cSQL= "select rgsCodigo, rgsNome from regiao order by rgsNome";
						$oTabela = mysqli_query($oConexao, $cSQL);

						while ($oReg = mysqli_fetch_assoc($oTabela)) 
              		    {
							echo '<option value="'.$oReg['rgsCodigo'].'">'. $oReg['rgsNome'].'</option>';						
				    	}
				    	mysqli_free_result($tabela);				
					?>
				</select>
			</label>

			<br>

			<label>
				População: <input type="number" name="txtPopulacao">
			</label>

			<br>

			<button>Cadastrar</button>
    	</form>
    	<table>

        
       		<!--aqui eu vou listar os estados-->
	  		<?php

	  			echo '<p>Estados cadastrados:</p>' .
                '<th>UF</th> <th>Cidade</th> <th>Capital</th> <th>Região</th> <th>População</th>';
           		$cSQL= "select * from estados";
            	$oTabela = mysqli_query($oConexao, $cSQL);

            	while ($oReg = mysqli_fetch_assoc($oTabela))
            	{
                	echo '<tr><td>'.$oReg['stdUF'].'</td><td>'.$oReg['stdCidade'].'</td><td>'.$oReg['stdCapital'].'</td><td>'.$oReg['stdRegiao'].'</td><td>'.$oReg['stdPopulacao'].'</td></tr>';
		
            	}
		   		mysqli_free_result($oTabela);	
	        	mysqli_close($oConexao);
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