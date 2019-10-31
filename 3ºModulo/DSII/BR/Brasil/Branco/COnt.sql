select  round( sum(cid_populacao)*100/(select sum(cid_populacao)  from cidade inner join estados on est_sigla = cid_estado where est_regiao = 'nordeste')) Porcentagem
 , cid_nome Nome ,est_nome Estado , concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor from cidade inner join estados on est_sigla = cid_estado where est_regiao = 'nordeste' group by est_nome;
select sum(cid_populacao), cid_nome ,est_nome from cidade inner join estados on est_sigla = cid_estado where est_regiao = 'sudeste' ;




    -- 1       
            select  round( sum(cid_populacao)*100/(select sum(cid_populacao)  from cidade inner join estados on est_sigla = cid_estado where est_regiao = 'nordeste')) Porcentagem
            ,est_nome Estado , concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor 
            from cidade inner join estados on est_sigla = cid_estado where est_regiao = 'nordeste' group by est_nome;
    -- 2
            select sum(cid_nome), est_regiao, concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor from estados inner join cidade on est_sigla = cid_estado group by 2;
            
	-- 3 
		 select sum(cid_populacao) Populacao, est_regiao Regiao , concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor from estados inner join cidade on est_sigla = cid_estado group by 2;
         
    -- 4      
		select count(est_nome) Estados, est_regiao Regiao , concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor from estados group by 2;
        
        
        
    -- 5 
		select cid_populacao popu , cid_nome Nome ,concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor  from cidade where cid_estado = 'SP' order by 1 desc;
        
	-- 6
		select cid_populacao popu , cid_nome Nome ,concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor  from cidade order by 1  desc limit 5;
	
    -- 7
		select count(cid_nome) quantidade, est_nome nome ,concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor  from cidade inner join estados on est_sigla = cid_estado group by 2 order by 1 desc  ;
	-- 8
		select count(cid_nome) quantidade, est_nome nome ,concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor  from cidade inner join estados on est_sigla = cid_estado group by 2 order by 1 desc  ;
        
        select cid_nome nome , cid_populacao ,concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor from cidade inner join estados on est_sigla = cid_estado where est_regiao = 'Nordeste' order by cid_populacao desc;
		