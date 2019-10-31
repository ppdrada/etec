create database amil;
	use amil;
    
create table paciente(
	cod_paciente int(5) not null primary key, 
    nome varchar(40) not null,
    CPF varchar(14) not null unique,
    endereco varchar(40),
    email varchar(40),
    rg varchar(20) not null unique,
    telefone varchar(10),
    cidade varchar(40)
);

select * from paciente;
select * from funcionario;
select * from salario;

insert into paciente(cod_paciente, nome, CPF, endereco, email, rg, telefone, cidade)values(12345, 
"José", 
"123.321.123-09", 
"rua dos esquecidos", 
"joseluis@gmail.com", 
"12.12.12-08", 
"91234-1234",
"São Paulo");

alter table paciente add altura float after cod_paciente;
alter table paciente add peso float first;

update paciente set altura=1.80 where cod_paciente=12345;
update paciente set peso=80 where cod_paciente=12345;

drop table paciente;

alter table paciente add logradouro varchar(40) after cod_paciente;

update paciente set logradouro="Sounibleine" where cod_paciente=12345;

create table funcionario
(
	matricula int not null primary key auto_increment,
    nome varchar(50) not null,
    sobrenome varchar(50) not null,
    endereco varchar(50),
    cidade varchar(50),
    pais varchar(25),
    data_nasc datetime
);

create table salario
(
	matricula int not null,
    salario decimal(10,2) not null,
    foreign key(matricula) references funcionario(matricula)
);

alter table funcionario add genero char(1);

alter table funcionario change genero sexo char(1);
