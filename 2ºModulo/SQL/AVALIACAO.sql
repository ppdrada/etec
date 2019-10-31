create database banco;
	use banco;
    
create table tbl_funcionario(

	id int not null primary key,
    nome_func varchar(40),
	RG varchar(13),
    CPF varchar(14),
    depto varchar(40),
    salario decimal,
    sindicalizado varchar(1)
);

insert into tbl_funcionario(id, nome_func, RG, CPF, depto, salario, sindicalizado) values(
	5,
    "João Cladio",
    "32.690.163-32",
    "633.215.551-45",
    "Informática",
    3500.00,
    "N"
);

select * from tbl_funcionario;

update tbl_funcionario set salario = salario * 1.15 where id=2; 

select * from tbl_funcionario where salario > 1500;
select * from tbl_funcionario where salario >= 3000 and salario <= 5000;

alter table tbl_funcionario add idade int after CPF;

select max(salario) from tbl_funcionario where salario;
select avg(salario) from tbl_funcionario where salario;
select min(salario) from tbl_funcionario where salario;
select count(*) from tbl_funcionario;

/*

2)

foreign key ou chave estrageira 
é a chave primaria de uma tabela migra para outra tabela 
em uma relação de tabelas, quando tabelas são relacionadas a chave primaria de uma tabela fica contida dentro da outra tabela.

*/
