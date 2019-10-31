
  use cadastro;
  
  
  
  create table cadastrar(
	numInden int(5)  primary key,
    nome varchar(45) not null,
    idade int(2),
    identidade varchar(45) not null,
    poder varchar(45) not null,
    Localiza varchar(45) not null
    
    );
    
    
    
   insert into cadastrar(exmDescricao) values ('Descrição do campo 1');

select * from cadastrar;