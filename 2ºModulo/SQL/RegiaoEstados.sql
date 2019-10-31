create database  Brasil;
 use Brasil;
 
create table regiao(
	rgsCodigo int auto_increment primary key,
    rgsNome varchar(30)
);

create table estados(
	stdUF varchar(2) primary key,
    stdCidade varchar(50) not null,
    stdCapital varchar(100),
    stdRegiao int,
    stdPopulacao numeric(10),
    constraint foreign key (stdRegiao) references regiao(rgsCodigo)
);



select * from estados;

select rgsCodigo, rgsNome from regiao;
