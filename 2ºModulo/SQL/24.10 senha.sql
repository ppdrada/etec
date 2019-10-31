create database banco;
 use banco;
 
 create table  usuario(
	 id_usario int not  null primary key auto_increment,
      nome_usuario varchar(45),
      senha varchar(45)
 );
 
 
 -- inserir registro
 insert into usuario(nome_usuario, senha) values ('Pedro',md5('12354'));
 
 select * from usuario;