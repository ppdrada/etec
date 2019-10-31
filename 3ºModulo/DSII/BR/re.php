   <?php
            $conexao = mysqli_connect("localhost","root","","Brasil");
            mysqli_set_charset($conexao, 'utf8');
            $regiao = " 
                fnPegaTexto(){
                    var Valores =  gettext(getElementById('A').value);
                }
            </script>";
            $vTitulo = array();
            $vValores = array();
            $vCor = array();
            $SQL = "select  round( sum(cid_populacao)*100/(select sum(cid_populacao)  from cidade inner join estados on est_sigla = cid_estado where est_regiao = 'nordeste')) Porcentagem
            ,est_nome Estado , concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor 
            from cidade inner join estados on est_sigla = cid_estado where est_regiao = 'nordeste' group by est_nome";
            $Tabela = mysqli_query($conexao, $SQL);
            while($oReg=mysqli_fetch_array($Tabela)){
              //echo '<h1>'.$oReg[0].'</h1><h3>'. $oReg[1].'</h3>';
              $vTitulo[]= $oReg['Estado'];
              $vValores[] =$oReg['Porcentagem'];
              $vCor[] = $oReg['Cor'];
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
    <script src="chart.js"></script>
    <select name = 'regiões' id = 'A' onclick="fnPegaTexto()">
        <option value="Nordeste" id='E' onclick="fnPegaTexto()">Nordeste</option>
        <option value="Norte" id='E' onclick="fnPegaTexto()">Norte</option>
        <option value="Centro-oeste" id='E' onclick="fnPegaTexto()"> Centro-oeste</option>
        <option value="Sudeste" id='E' onclick="fnPegaTexto()">Sudeste</option>
        <option value="Sul" id='E' onclick="fnPegaTexto()">Sul</option>
    </select>    
    <script>
        var oGrafico = new Chart(document.all.objgrafico.getContext('2d'), 
            { 
                type: 'pie',
                data: {  
                    labels: <?php echo json_encode($vTitulo, JSON_UNESCAPED_UNICODE) ?>  ,
                    datasets: [ 
                        { 
                            label: 'Estados do Brasil por População', 
                            data: <?php echo json_encode($vValores )?>,
                            backgroundColor: <?php echo json_encode($vCor)?>,
                           // borderColor: [ '#009E3F' ]  
                        } 
                    ]
                } 
            });             
    </script>
</html>

