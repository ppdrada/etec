select cid_estado , sum(cid_populacao) from cidade group by cid_estado;
select estados.est_nome estados, sum(cid_populacao) população from cidade inner join estados on cid_estado = est_sigla group by cid_estado ;
select concat(estados.est_nome ,' - ' , est_sigla),est_nome, sum(cid_populacao) from cidade inner join estados on cid_estado = est_sigla group by cid_estado;




