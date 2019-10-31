create database amil;
	use amil;
create table medico( 
 crm int not null primary key,
 nome varchar(45),
 cpf varchar(45),
 salario decimal(10,2),
 especialidade varchar (45)
 );
create table Paciente(
CodPaciente int not null primary key,
cpf varchar(45),
rg varchar(45),
nome varchar(45),
cidade varchar(45),
idade varchar(45)
);
 alter table amil rename pedro;
 