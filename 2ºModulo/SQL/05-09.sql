create database pais;
	use pais;

create table senso(
	cod_uf int primary key not null,
    ano int (4),
    nome_mun varchar (50),
    populacao int (20));    
    

    select * from senso;
    
    select * from senso
    where cod_uf = '35' 
		
		and ano= '2014';
	
    -- usando operador <= 
    
    select * from senso
    where nome_mun = 'Dourado'
		and cod_uf ='35'
        and ano='2014';
	
    -- usando o operador > 
    select * from	senso
    where cod_uf <> '35'
    
    and cod_uf <> '14'
    and ano='2014';
    
    select * from senso
    where populacao <= 100000
		and populacao >= 50000
		and cod_uf ='105'
		and nome_mun <> 'Vinhedo'
			and ano='2014';
            -- <3
    
