    <style>
button {
  background-color:rgb(113, 121, 135);
  color: white;
  border: 2px solid rgb(113, 121, 135);
  cursor:pointer;
}

button:hover {
  background-color:  rgba(255, 255, 255,0.3);
  color:#555555;
  border: 2px solid   rgba(255, 255, 255,0.3);
  cursor:pointer;
}
div{
    border:15px solid transparent;
    
}

select {
    cursor:pointer;
}

form{
    background-Color: rgba(77, 84, 96, 0.5);
}
img{
    height: 50px;
    width:50px;
    margin-top: -20px;
    margin-bottom: -20px;

}
</style>
     
     <?php
            $conexao = mysqli_connect("localhost","root","","Brasil");
            mysqli_set_charset($conexao, 'utf8');
			$vTitulo = array();
            $vValores = array();
            $vCor = array();
            $vVetor = $_GET['regiao'];
			$SQL = 'bar';
			$cEsc;
			if($vVetor == 'numero'){
				$cEsc = 'bar';
				 $SQL = "select count(cid_nome) Nome, est_regiao Regiao, 
				 concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor from estados 
				 inner join cidade on est_sigla = cid_estado group by 2";
				 $Tabela = mysqli_query($conexao, $SQL);
            while($oReg=mysqli_fetch_array($Tabela)){
              //echo '<h1>'.$oReg[0].'</h1><h3>'. $oReg[1].'</h3>';
              $vTitulo[]= $oReg['Regiao'];
              $vValores[] =$oReg['Nome'];
              $vCor[] = $oReg['Cor'];
			}
				
			}
			if($vVetor == 'populacao'){
                $cEsc = 'bar';
            
				$SQL = "select sum(cid_populacao) Populacao, est_regiao Regiao ,
				concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor from estados 
				inner join cidade on est_sigla = cid_estado group by 2;";
            $Tabela = mysqli_query($conexao, $SQL);
            while($oReg=mysqli_fetch_array($Tabela)){
              //echo '<h1>'.$oReg[0].'</h1><h3>'. $oReg[1].'</h3>';
              $vTitulo[]= $oReg['Regiao'];
              $vValores[] =$oReg['Populacao'];
              $vCor[] = $oReg['Cor'];
			}
			}
			if($vVetor == 'estados'){
				$cEsc = 'bar';
				$SQL = "select count(est_nome) Estados, est_regiao Regiao , concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor from estados group by 2;";
			
            
            
            $Tabela = mysqli_query($conexao, $SQL);
            while($oReg=mysqli_fetch_array($Tabela)){
              
              $vTitulo[]= $oReg['Regiao'];
              $vValores[] =$oReg['Estados'];
              $vCor[] = $oReg['Cor'];
			}
			}
			if($vVetor == 'Norte' ||$vVetor == 'Sul' ||$vVetor == 'Sudeste' ||$vVetor == 'Centro-oeste' ||$vVetor == 'Nordeste'  ){
				$cEsc = 'pie';
				$SQL = "select  round( sum(cid_populacao)*100/(select sum(cid_populacao)  from cidade inner join estados on est_sigla = cid_estado where est_regiao = '".$vVetor ."')) Porcentagem
            ,est_nome Estado , concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor 
            from cidade inner join estados on est_sigla = cid_estado where est_regiao ='".$vVetor."' group by est_nome";
			
            
            
            $Tabela = mysqli_query($conexao, $SQL);
            while($oReg=mysqli_fetch_array($Tabela)){
              
              $vTitulo[]= $oReg['Estado'];
              $vValores[] =$oReg['Porcentagem'];
              $vCor[] = $oReg['Cor'];
			}
            }
			if($vVetor == 'SaoPaulo'){
				$cEsc = 'bar';
				$SQL = "select cid_populacao popu , cid_nome Nome ,concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor  from cidade where cid_estado = 'SP' order by 1 desc limit 10";
				
            
            
            $Tabela = mysqli_query($conexao, $SQL);
            while($oReg=mysqli_fetch_array($Tabela)){
             
              $vTitulo[]= $oReg['Nome'];
              $vValores[] =$oReg['popu'];
              $vCor[] = $oReg['Cor'];
			}
			}
			if($vVetor == 'Brasil'){
				$cEsc = 'bar';
				$SQL = "select cid_populacao Popu , cid_nome Nome ,concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor  from cidade order by 1 desc limit 5";
				
            
            
            $Tabela = mysqli_query($conexao, $SQL);
                while($oReg=mysqli_fetch_array($Tabela)){
            
                    $vTitulo[]= $oReg['Nome'];
                    $vValores[] =$oReg['Popu'];
                    $vCor[] = $oReg['Cor'];
			    }
			}
			
			if($vVetor == 'quat'){
				$cEsc = 'bar';
				$SQL = "select cid_populacao Popu , cid_nome Nome ,concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor  from cidade order by 1 desc limit 5";
				
            
            
            $Tabela = mysqli_query($conexao, $SQL);
                while($oReg=mysqli_fetch_array($Tabela)){
           
                    $vTitulo[] = $oReg['Nome'];
                    $vValores[] =$oReg['Popu'];
                    $vCor[] = $oReg['Cor'];
			    }
			}
			if($vVetor == 'quant1' ){
				$cEsc = 'horizontalBar';
				$SQL = "		select count(cid_nome) quantidade, est_nome nome ,concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor  from cidade inner join estados on est_sigla = cid_estado group by 2 order by 1 desc  ";
			
            
            
            $Tabela = mysqli_query($conexao, $SQL);
                while($oReg=mysqli_fetch_array($Tabela)){
        
                    $vTitulo[] = $oReg['nome'];
                    $vValores[] =$oReg['quantidade'];
                    $vCor[] = $oReg['Cor'];
			    }
            }

            mysqli_free_result($Tabela);
           //mysqli_set_charset(UTF-8);
            mysqli_set_charset($conexao, 'utf8');
       //Aqui eu vou listar os estados;
            mysqli_close($conexao);
           // echo json_encode($vTitulo, JSON_UNESCAPED_UNICODE);
            //echo json_encode($vValores);
			
        ?>
       
 <html>
          
    <body>
        <canvas id="objgrafico" width="800" height="350"></canvas>
    </body>
    <form action="re1.php"   >
    <div>
        <center><script src="chart.js"></script>
        <select name = 'regiao' id = 'AI' >
            <option value="Nordeste" id='E' >Porcentagem da população no Nordeste</option>
            <option value="Norte" id='E' >Porcentagem da população no Norte</option>
            <option value="Centro-oeste" id='E' > Porcentagem da população no Centro-oeste</option>
            <option value="Sudeste" id='E' >Porcentagem da população no Sudeste</option>
            <option value="Sul" id='E' >Porcentagem da população no Sul</option>
			<option value="numero"> Numero de cidades por região</option> 
			<option value="populacao"> Numero da população por região</option> 
			<option value="estados"> Numeros de estados por região</option> 
			<option value="SaoPaulo"> Cidades mais populosas de São Paulo</option> 
			<option value="Brasil"> Cidades mais populosas do Brasil</option> 
			<option value="quat" id = "A"> Estados com mais cidades no Brasil</option> 
			<option value="quant1"> Numero de cidades em cada estado </option> 
			
        </select> 
        <?php 
        if(isset($_GET['regiao'])){
            echo '<script> document.getElementById("AI").value = "' . $_GET['regiao'] .'"</script>'; 
        }
        ?>   
        <button >Confirmar</button>
        <img src='Rammus.png'>
    </center>
    </form>
   
    <?php 
    $conexao = mysqli_connect("localhost","root","","Brasil");
    mysqli_set_charset($conexao, 'utf8');
    mysqli_close($conexao);
    
    ?>
    <script>
        var A = document.getElementById("AI").innerHTML;
        var oGrafico = new Chart(document.all.objgrafico.getContext('2d'), 
            { 
                type: '<?php echo($cEsc)?>',
                data: {  
                    labels: <?php echo json_encode($vTitulo, JSON_UNESCAPED_UNICODE) ?>  ,
                    datasets: [ 
                        { 
                            label: document.getElementById("AI").options[document.getElementById("AI").selectedIndex].innerText, 
                            data: <?php echo json_encode($vValores )?>,
                            backgroundColor: <?php echo json_encode($vCor)?>,
                           // borderColor: [ '#009E3F' ]  
                        } 
                    ]
                } 
            });             
    </script>
     
</html>

