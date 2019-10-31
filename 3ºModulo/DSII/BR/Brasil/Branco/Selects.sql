SELECT COUNT(distinct(EST_NOME)), SUM(CID_POPULACAO) FROM CIDADE INNER JOIN ESTADOS ON EST_REGIAO;

SELECT COUNT(distinct(EST_NOME)), SUM(CID_POPULACAO) FROM CIDADE INNER JOIN ESTADOS ON EST_REGIAO = 'Sudeste' ORDER BY CID_POPULACAO ASC;

select DISTINCT(EST_NOME), EST_REGIAO from `ESTADOS` order by EST_NOME ASC; -- 1
    
select EST_NOME, SUM(cid_populacao) from `ESTADOS` INNER JOIN cidade on CID_ESTADO order by EST_NOME ASC;


 select cid_nome, cid_populacao from cidade ORDER BY cid_populacao desc ; -- 2
 
 select cid_nome, cid_populacao  from cidade ORDER BY cid_populacao DESC  limit 5; -- 5
 
 select count(est_nome) from estados where est_regiao = 'sudeste'; -- 2
 
 select cid_nome, cid_populacao from cidade where cid_populacao > 1000000 order by cid_nome ; -- 4
 
  select cid_nome, cid_populacao from cidade where cid_estado = 'SP' ;
  
   -- select cid_nome, cid_populacao from cidade where cid_estado = 'SP' ;
   select cid_nome, cid_populacao from cidade where cid_estado = 'SP' order by cid_populacao desc ;
   
   select  count(distinct(est_nome)) contador , sum(cid_populacao) populacao from estados inner join cidade on cid_populacao where est_regiao = 'Sudeste' group by(est_regiao) ; 
 -- select   est_nome , sum(cid_populacao) from estados left join cidade on cid_populacao  order by cid_populacao desc limit 3;
 
select cid_nome, cid_populacao  from cidade inner join estados on cid_estado = est_sigla ORDER BY cid_populacao DESC  limit 3;

select cid_nome, cid_populacao  from cidade inner join estados on cid_estado = est_sigla ORDER BY cid_populacao DESC  limit 3;

 select count(distinct(est_nome)) contador , sum(cid_populacao) populacao from estados inner join cidade on cid_estado = est_sigla where est_regiao = 'Sudeste' group by(est_regiao) ; -- 3  -- 3
 -- 3
 select est_nome contador , sum(cid_populacao) populacao from estados inner join cidade on cid_estado = est_sigla where est_regiao = 'Sudeste' group by est_nome;
 
select   * from  cidade inner join estados on cid_estado = est_sigla  order by cid_estado ;

select estados.est_nome Estado, sum(cid_populacao) Populacao, concat('rgb(', cast(rand()*255 as unsigned), ', ',  cast(rand()*255 as unsigned), ',' , cast(rand()*255 as unsigned) ,')') Cor from cidade inner join estados on cid_estado = est_sigla group by cid_estado;