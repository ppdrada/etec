create database EstadosBr;
	use EstadosBr;
CREATE TABLE estadosbr (
  stdsigla varchar(2) NOT NULL,
  stdnome varchar(50) NOT NULL,
  stdcapital varchar(150) DEFAULT NULL,
  stdregiao int(11) DEFAULT NULL,
  stdpopulacao int(11) DEFAULT NULL,
  PRIMARY KEY (stdsigla)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('AC','Acre','Rio Branco',1,'795145');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('AL','Alagoas','Maceió',2,'3327551');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('AP','Amapá','Macapá',1,'756500');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('AM','Amazonas','Manaus',1,'3893763');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('BA','Bahia','Salvador',2,'15150143');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('CE','Ceará','Fortaleza',2,'8867448');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('DF','Distrito Federal','Brasília',3,'2867869');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('ES','Espírito Santo','Vitória',4,'3894899');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('GO','Goiás','Goiânia ',3,'6551322');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('MA','Maranhão','São Luís',2,'6861924');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('MT','Mato Grosso','Cuiabá',3,'3236578');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('MS','Mato Grosso do Sul','Campo Grande',3,'2630098');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('MG','Minas Gerais','Belo Horizonte',4,'20777672');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('PA','Pará','Belém',1,'8101180');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('PB','Paraíba','João Pessoa',2,'3950359');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('PR','Paraná','Curitiba',5,'1111062');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('PE','Pernambuco','Recife',2,'9297861');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('PI','Piauí','Teresina',2,'3198185');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('RJ','Rio de Janeiro','Rio de Janeiro',4,'16497395');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('RN','Rio Grande do Norte','Natal',2,'3419550');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('RS','Rio Grande do Sul','Porto Alegre',5,'11228091'); 
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('RO','Rondônia','Porto Velho',1,'1755015');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('RR','Roraima','Boa Vista',1,'500826');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('SC','Santa Catarina','Florianópolis',5,'6734568');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('SP','São Paulo','São Paulo',5,'44169350');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('SE','Sergipe','Aracaju',2,'2227294');
insert into estadosbr(stdsigla,stdnome,stdcapital,stdregiao,stdpopulacao) values ('TO','Tocantins','Palmas',1,'1502759');

select * from estadosbr;

