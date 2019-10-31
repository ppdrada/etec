create database banco;
	use banco;

create table funcionarios(
	id int not null primary key,
    
    nomefun varchar(45),
    CPF varchar(14),
    RG varchar(13),
    departamento varchar(40),
    salario  float,
    sindicalizado varchar (1) 
);

insert into funcionarios(id,nomefun,CPF,RG,departamento,salario,sindicalizado) values(
	01,
    "Caio Levantes",
    "12.123.123-34",
    "849.494.375-72",
    "Analise",
    2000.00,
    "Não"
    
);
insert into funcionarios(id,nomefun,CPF,RG,departamento,salario,sindicalizado) values(
	02,
    "Jacobi",
    "23.423.525-23",
    "456.849.375-34",
    "Juridico",
    3000.00,
    "Sim"
    
);
insert into funcionarios(id,nomefun,CPF,RG,departamento,salario,sindicalizado) values(
	03,
    "Marlom",
    "56.545.645-11",
    "843.344.375-53",
    "Desenvolvedor",
    2500.00,
    "Sim"
    
);
select * from funcionarios;

update funcionarios set salario = salario *1.15 where id=4; /* Salário em 15% onde o cóigo*/

select * from funcionarios where salario > 1500.00;
select * from funcionarios where salario >= 3000.00 && salario <= 5000.00;

alter table funcionarios add idade int after nomefun;

select max(salario) from funcionarios where salario;
select avg(salario) from funcionarios where salario;
select min(salario) from funcionarios where salario;

select count(*) from funcionarios;

/*
2)É uma chave primaria
