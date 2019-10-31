create database ControleDeDespesas;
	use ControleDeDespesas;
    
create table despesas(
	
    descricao varchar(50),
    datavenc date,
    valor decimal(10,2),
    multa decimal(10,2),
    vencido bool
);

insert into despesas(descricao, dtvencimento, valor, multa, vencido, obs) values(

	"conta de água",
    "2018/09/16",
    95.99,
    5,
    "n",
    "pagar com antescedência"

);

select * from despesas;

alter table despesas change datavenc dtvencimento varchar(10);
alter table despesas change vencido vencido varchar(1);
alter table despesas add obs varchar(30) after vencido;

select * from despesas 
where dtvencimento > "2018/09/15";
