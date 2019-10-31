<html>

   
            <?php
            $conexao = mysqli_connect("localhost","root","","Brasil");
            mysqli_set_charset($conexao, 'utf8');
            $SQL = "select concat(estados.est_nome ,' - ' , est_sigla),est_nome, sum(cid_populacao) from cidade inner join estados on cid_estado = est_sigla group by cid_estado";
       $Tabela = mysqli_query($conexao, $SQL);
           while($oReg=mysqli_fetch_array($Tabela))
               echo '<h1>'.$oReg[0].'</h1><h3>'. $oReg[1].'</h3>';
           mysqli_free_result($Tabela);
           //mysqli_set_charset(UTF-8);
           mysqli_set_charset($conexao, 'utf8');
       //Aqui eu vou listar os estados;
       mysqli_close($conexao);
        ?>


</html>