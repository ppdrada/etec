-- phpMyAdmin SQL Dump
-- version 4.6.6
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 15-Fev-2019 às 18:41
-- Versão do servidor: 5.6.35
-- PHP Version: 7.1.1

--
-- Database: `acervo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `artistas`
--

create database play;
use play; 

CREATE TABLE `artistas` (
  `ARTCODIGO` int(10) UNSIGNED NOT NULL,
  `ARTNOME` varchar(150) NOT NULL,
  `ARTPAIS` int(10) UNSIGNED DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `bandas`
--

CREATE TABLE `bandas` (
  `BDSCODIGO` int(10) UNSIGNED NOT NULL,
  `BDSNOME` varchar(150) NOT NULL,
  `BDSANO` year(4) DEFAULT NULL,
  `BDSPAIS` int(10) UNSIGNED DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `bandas`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `discos`
--

CREATE TABLE `discos` (
  `DSCCODIGO` int(10) UNSIGNED NOT NULL,
  `DSCNOME` varchar(150) NOT NULL,
  `DSCBANDA` int(10) UNSIGNED DEFAULT NULL,
  `DSCARTISTA` int(10) UNSIGNED DEFAULT NULL,
  `DSCANOLANC` int(4) NOT NULL,
  `DSCGRAVADORA` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `discos`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `exemplo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcoes`
--

CREATE TABLE `funcoes` (
  `FNCCODIGO` int(10) UNSIGNED NOT NULL,
  `FNCNOME` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `gravadoras`
--

CREATE TABLE `gravadoras` (
  `GRVCODIGO` int(10) UNSIGNED NOT NULL,
  `GRVNOME` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `integrantes`
--

CREATE TABLE `integrantes` (
  `ITGCODIGO` int(10) UNSIGNED NOT NULL,
  `ITGBANDA` int(10) UNSIGNED NOT NULL,
  `ITGARTISTA` int(10) UNSIGNED NOT NULL,
  `ITGDTINI` int(4) DEFAULT NULL,
  `ITGDTFIM` int(4) DEFAULT NULL,
  `ITGFUNCAO` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `musicas`
--

CREATE TABLE `musicas` (
  `MSCCODIGO` int(10) UNSIGNED NOT NULL,
  `MSCNOME` varchar(150) NOT NULL,
  `MSCFAIXA` tinyint(4) DEFAULT NULL,
  `MSCDISCO` int(10) UNSIGNED NOT NULL,
  `MSCDURACAO` time DEFAULT NULL,
  `MSCBANDA` int(10) UNSIGNED DEFAULT NULL,
  `MSCARTISTA` int(10) UNSIGNED DEFAULT NULL,
  `MSCLETRA` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `musicas`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `paises`
--

CREATE TABLE `paises` (
  `PSSCODIGO` int(10) UNSIGNED NOT NULL,
  `PSSNOME` varchar(150) NOT NULL,
  `PSSSIGLA` char(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `paises`
--


--
-- Indexes for dumped tables
--

--
-- Indexes for table `artistas`
--
ALTER TABLE `artistas`
  ADD PRIMARY KEY (`ARTCODIGO`),
  ADD KEY `FK_PSSART` (`ARTPAIS`);

--
-- Indexes for table `bandas`
--
ALTER TABLE `bandas`
  ADD PRIMARY KEY (`BDSCODIGO`),
  ADD KEY `FK_PSSBDS` (`BDSPAIS`);

--
-- Indexes for table `discos`
--
ALTER TABLE `discos`
  ADD PRIMARY KEY (`DSCCODIGO`),
  ADD KEY `FK_GRVDSC` (`DSCGRAVADORA`),
  ADD KEY `FK_ARTDSC` (`DSCARTISTA`),
  ADD KEY `FK_BDSDSC` (`DSCBANDA`);

--
-- Indexes for table `funcoes`
--
ALTER TABLE `funcoes`
  ADD PRIMARY KEY (`FNCCODIGO`);

--
-- Indexes for table `gravadoras`
--
ALTER TABLE `gravadoras`
  ADD PRIMARY KEY (`GRVCODIGO`);

--
-- Indexes for table `integrantes`
--
ALTER TABLE `integrantes`
  ADD PRIMARY KEY (`ITGCODIGO`),
  ADD KEY `FK_FNCITG` (`ITGFUNCAO`),
  ADD KEY `FK_BDSITG` (`ITGBANDA`),
  ADD KEY `FK_ARTITG` (`ITGARTISTA`);

--
-- Indexes for table `musicas`
--
ALTER TABLE `musicas`
  ADD PRIMARY KEY (`MSCCODIGO`),
  ADD KEY `FK_DSCMSC` (`MSCDISCO`),
  ADD KEY `FK_BDSMSC` (`MSCBANDA`),
  ADD KEY `FK_ARTMSC` (`MSCARTISTA`);

--
-- Indexes for table `paises`
--
ALTER TABLE `paises`
  ADD PRIMARY KEY (`PSSCODIGO`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `artistas`
--
ALTER TABLE `artistas`
  MODIFY `ARTCODIGO` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `bandas`
--
ALTER TABLE `bandas`
  MODIFY `BDSCODIGO` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `discos`
--
ALTER TABLE `discos`
  MODIFY `DSCCODIGO` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `funcoes`
--
ALTER TABLE `funcoes`
  MODIFY `FNCCODIGO` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `gravadoras`
--
ALTER TABLE `gravadoras`
  MODIFY `GRVCODIGO` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `integrantes`
--
ALTER TABLE `integrantes`
  MODIFY `ITGCODIGO` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `musicas`
--
ALTER TABLE `musicas`
  MODIFY `MSCCODIGO` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `paises`
--
ALTER TABLE `paises`
  MODIFY `PSSCODIGO` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `artistas`
--
ALTER TABLE `artistas`
  ADD CONSTRAINT `FK_PSSART` FOREIGN KEY (`ARTPAIS`) REFERENCES `paises` (`PSSCODIGO`);

--
-- Limitadores para a tabela `bandas`
--
ALTER TABLE `bandas`
  ADD CONSTRAINT `FK_PSSBDS` FOREIGN KEY (`BDSPAIS`) REFERENCES `paises` (`PSSCODIGO`);

--
-- Limitadores para a tabela `discos`
--
ALTER TABLE `discos`
  ADD CONSTRAINT `FK_ARTDSC` FOREIGN KEY (`DSCARTISTA`) REFERENCES `artistas` (`ARTCODIGO`),
  ADD CONSTRAINT `FK_BDSDSC` FOREIGN KEY (`DSCBANDA`) REFERENCES `bandas` (`BDSCODIGO`),
  ADD CONSTRAINT `FK_GRVDSC` FOREIGN KEY (`DSCGRAVADORA`) REFERENCES `gravadoras` (`GRVCODIGO`);

--
-- Limitadores para a tabela `integrantes`
--
ALTER TABLE `integrantes`
  ADD CONSTRAINT `FK_ARTITG` FOREIGN KEY (`ITGARTISTA`) REFERENCES `artistas` (`ARTCODIGO`),
  ADD CONSTRAINT `FK_BDSITG` FOREIGN KEY (`ITGBANDA`) REFERENCES `bandas` (`BDSCODIGO`),
  ADD CONSTRAINT `FK_FNCITG` FOREIGN KEY (`ITGFUNCAO`) REFERENCES `funcoes` (`FNCCODIGO`);

--
-- Limitadores para a tabela `musicas`
--
ALTER TABLE `musicas`
  ADD CONSTRAINT `FK_ARTMSC` FOREIGN KEY (`MSCARTISTA`) REFERENCES `artistas` (`ARTCODIGO`),
  ADD CONSTRAINT `FK_BDSMSC` FOREIGN KEY (`MSCBANDA`) REFERENCES `bandas` (`BDSCODIGO`),
  ADD CONSTRAINT `FK_DSCMSC` FOREIGN KEY (`MSCDISCO`) REFERENCES `discos` (`DSCCODIGO`);
  
  
/*---------------------------------------------------------------------- INSERTs -------------------------------------------------------------------------------------*/
-- PAISES
  
  insert into paises(pssnome,psssigla) values('Estados Unidos da América', 'USA');
  insert into paises(pssnome,psssigla) values('Córeia do Sul', 'KOR');
  insert into paises(pssnome,psssigla) values('Brasil', 'BRA');
  insert into paises(pssnome,psssigla) values('Reino Unido', 'UK');
  insert into paises(pssnome,psssigla) values('Islândia', 'IS');
  insert into paises(pssnome,psssigla) values('Suécia', 'SWE');
  insert into paises(pssnome,psssigla) values('Barbados', 'BB');
  insert into paises(pssnome, psssigla) values('Teste', 'TS');
  insert into paises(psscodigo, pssnome, psssigla) values(8,'Teste', 'TS');
  
  delete  from musicas;
  commit;
  start transaction;
  rollback;
 select * from paises;
  
  
  
-- BANDAS
  
  insert into bandas(bdsnome, bdsano, bdspais ) value ('Linkin Park',1996,1);
  insert into bandas(bdsnome, bdsano, bdspais ) value ('Kard',2016,2);
  insert into bandas(bdsnome, bdsano, bdspais ) value ('Supercombo',2006,3);
  insert into bandas(bdsnome, bdsano, bdspais ) value ('Coldplay',1996,4);
  insert into bandas(bdsnome, bdsano, bdspais ) value ('Kaleo',2012,5);
-- select * from bandas;



-- ARTISTAS

-- LinKin Park
  insert into artistas(ARTNOME,ARTPAIS) values('Chester Bennington',1);
  insert into artistas(ARTNOME,ARTPAIS) values('Mike Shinoda',1);
  insert into artistas(ARTNOME,ARTPAIS) values('Joe Hahn',1);
  insert into artistas(ARTNOME,ARTPAIS) values('Brad Delson',1);
  insert into artistas(ARTNOME,ARTPAIS) values('Rob Bourdon',1);
  insert into artistas(ARTNOME,ARTPAIS) values('Dave Farrell',1);
  
-- Kard 
  insert into artistas(ARTNOME,ARTPAIS) values('Jiwoo',2);
  insert into artistas(ARTNOME,ARTPAIS) values('Jeon So-min',2);
  insert into artistas(ARTNOME,ARTPAIS) values('Matthew Kim',2);
  insert into artistas(ARTNOME,ARTPAIS) values('J.Seph',2);
  
-- Supercombo
  insert into artistas(ARTNOME,ARTPAIS) values('Gustavo Rizzo',3);
  insert into artistas(ARTNOME,ARTPAIS) values('Pedro Ramos',3);
  insert into artistas(ARTNOME,ARTPAIS) values('Carol Navarro',3);
  insert into artistas(ARTNOME,ARTPAIS) values('Paulo Vaz',3);
  insert into artistas(ARTNOME,ARTPAIS) values('Raul de Paula',3);
  
-- CodPlay
  insert into artistas(ARTNOME,ARTPAIS) values('Chris Martin',4);
  insert into artistas(ARTNOME,ARTPAIS) values('Guy Berryman',4);
  insert into artistas(ARTNOME,ARTPAIS) values('Will Champion',4);
  insert into artistas(ARTNOME,ARTPAIS) values('Jonny Buckland',4);

-- Kaleo 
  insert into artistas(ARTNOME,ARTPAIS) values('Jökull Júlíusson',5);
  insert into artistas(ARTNOME,ARTPAIS) values('Rubin Pollock',5);
  insert into artistas(ARTNOME,ARTPAIS) values('Daníel Ægir Kristjánsson',5);
  insert into artistas(ARTNOME,ARTPAIS) values('Davíð Antonsson',5);  
  
-- ARTISTAS SOLO 
  insert into artistas(ARTNOME,ARTPAIS) values('Emicida',3);
  insert into artistas(ARTNOME,ARTPAIS) values('Rubel',3);
  insert into artistas(ARTNOME,ARTPAIS) values('Harry Styles',4); 
  insert into artistas(ARTNOME,ARTPAIS) values('Avicci',6);
  insert into artistas(ARTNOME,ARTPAIS) values('Lady Gaga',1);
  insert into artistas(ARTNOME,ARTPAIS) values('Rihanna',7);
  
-- select * from artistas;



-- FUNÇÔES
 
  insert into funcoes(fncnome) values ('Vocalista');
  insert into funcoes(fncnome) values ('Baterista');
  insert into funcoes(fncnome) values ('Baixista');
  insert into funcoes(fncnome) values ('Guitarrista');
  insert into funcoes(fncnome) values ('Tecladista');
  insert into funcoes(fncnome) values ('DJ');
  insert into funcoes(fncnome) values ('Violonista');
-- select * from funcoes;



-- INTEGRANTES

-- Linlin Park
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(1,1,1999,2017, 1);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(1,2,1996,null, 5);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(1,3,1996,null, 6);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(1,4,1996,null, 4);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(1,5,1996,null, 2);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(1,1,1999,null, 3);

-- Kard
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(2,7,2016,null, 1);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(2,8,2016,null, 1);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(2,9,2016,null, 1);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(2,10,2016,null, 1);
    
-- Supercombo
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(3,11,2006,null, 1);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(3,12,2006,null, 4);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(3,13,2006,null, 3);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(3,14,2006,null, 5);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(3,15,2006,null, 2);
    
-- CodPlay
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(4,16,1996,null, 1);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(4,17,1996,null, 7);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(4,18,1997,null, 5);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(4,19,1996,null, 4);
    
-- Kaleo
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(5,20,2012,null, 1);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(5,21,2012,null, 4);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(5,22,2012,null, 3);
  insert into integrantes(itgbanda, itgartista,itgdtini, itgdtfim, itgfuncao) 
    values(5,23,2012,null, 2);
-- select * from integrantes;



-- GRAVADORA

  insert into gravadoras(grvnome) values ('Warner Bros. Records'); -- Linkin Park
  insert into gravadoras(grvnome) values ('DSP Media'); -- Kard
  insert into gravadoras(grvnome) values ('Deckdisc');-- Supercombo
  insert into gravadoras(grvnome) values ('Parlophone Records');-- Codplay
  insert into gravadoras(grvnome) values ('Atlantic Records');-- Kaleo
  insert into gravadoras(grvnome) values ('Sony Music Brasil');-- Emicida
  insert into gravadoras(grvnome) values ('Tratore');-- Rubel
  insert into gravadoras(grvnome) values ('Columbia Records');-- Harry Styles
  insert into gravadoras(grvnome) values ('Universal Music Group');-- Avicii
  insert into gravadoras(grvnome) values ('Interscope Records');-- Lady Gaga
  insert into gravadoras(grvnome) values ('Roc Nation');-- Rihanna
-- select * from gravadoras;



-- DISCOS
 
-- Linkin park
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Meteora', 1, 2007, 1);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('One more lights', 1, 2017, 1);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('One Hot Minute', 1, 2007, 1);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('One Hot Minute', 1, 2012, 1);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('A Thousand Suns', 1, 2010, 1);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('A Thousand Suns', 1, 2010, 1);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Hybrid Theory', 1, 2012,1);

-- Kard
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Ride on the Wind', 2, 2018, 2);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('You & Me', 2, 2017, 2);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Lovebird', 2, 2017, 2);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Hola Hola', 2, 2017, 2);
  
-- Supercombo
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Rogério', 3, 2016, 3);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Amianto', 3, 2014, 3);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Sal Grosso', 3, 2011, 3);

-- Codplay
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Ghost Stories', 4, 2014, 4);
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('Parachutes', 4, 2000, 4);

-- Kaleo
  insert into discos(dscnome, dscbanda , dscanolanc, dscgravadora) values('A/B', 5, 2016, 5);

-- Emicida
  insert into discos(dscnome, DSCARTISTA , dscanolanc, dscgravadora) values('10 Anos de Triunfo', 24, 2018, 6);
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('O Glorioso Retorno de Quem Nunca Esteve Aqui', 24, 2013, 6);
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('Pra quem já mordeu um cachorro por comida, até que eu cheguei longe...', 24, 2019, 6);

-- Rubel
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('Casas', 25, 2018, 7);
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('Pearl', 25, 2013, 7);

-- Harry Styles
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('Harry Styles', 26, 2017, 8);

-- Avicii
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('Stories', 27, 2015, 9);
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('True', 27, 2013, 9);

-- Lady Gaga
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('Joanne', 28, 2016, 10);
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('The Fame', 28, 2008, 10);
  
-- Rihanna
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('Anti', 29, 2016, 11);
  insert into discos(dscnome, dscartista , dscanolanc, dscgravadora) values('Loud', 29, 2010, 11);

-- select * from discos;



-- MUSICAS

/*--------------------------------------------------- Linkin Park 12 ------------------------------------------------------------------------------------------*/
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Nobody Can Save Me',1,1,'00:03:45',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Good Goodbye ',2,1,'00:03:31',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Talking to Myself ',3,1,'00:03:51',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Battle Symphony  ',4,1,'00:03:36',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Invisible   ',5,1,'00:03:34',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Heavy ',6,1,'00:02:49',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Sorry for Now  ',7,1,'00:03:23',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Halfway Right  ',8,1,'00:03:37',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('One More Light  ',9,1,'00:04:15',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Sharp Edges  ',10,1,'00:02:58',1);

insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('  Nobody Can Save Me ',1,2,'00:03:45',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values(' Good Goodbye ',2,2,'00:03:31',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values(' Talking to Myself ',3,2,'00:03:51',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('  Battle Symphony  ',4,2,'00:03:36',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values(' Invisible   ',5,2,'00:03:34',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values(' Heavy ',6,2,'00:02:49',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values(' Sorry for Now  ',7,2,'00:03:23',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('  Halfway Right   ',8,2,'00:03:37',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values(' One More Light',9,2,'00:04:15',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Sharp Edges ',10,2,'00:02:58',1);

insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Wake',1,3,'00:01:43',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Given Up',2,3,'00:03:11',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Leave Out All the Rest  ',3,3,'00:03:31',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Bleed It Out',4,3,'00:02:46',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Shadow of the Day  ',5,3,'00:04:52',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('What Ive Done  ',6,3,'00:03:28',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Hands Held High  ',7,3,'00:03:55',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('No More Sorrow  ',8,3,'00:03:43',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Valentine s Day  ',9,3,'00:03:18',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('In Between  ',10,3,'00:03:18',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('In Pieces',11,3,'00:03:38',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('The Little Things Give You Away ',12,3,'00:06:25',1);

insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Lost in the Echo',1,4,'00:03:25',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('In My Remains',2,4,'00:03:20',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Burn It Down',3,4,'00:03:50',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Lies Greed Misery',4,4,'00:02:26',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('I ll Be Gone',5,4,'00:03:31',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Castle of Glass',6,4,'00:03:25',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Victimized',7,4,'00:01:46',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Roads Untraveled',8,4,'00:03:49',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Skin to Bone',9,4,'00:02:48',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Until It Breaks',10,4,'00:03:43',1);

insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('The Requiem',1,5,'00:02:01',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('The Radiance',2,5,'00:00:57',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Burning in the Skies',3,5,'00:04:13',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Empty Spaces',4,5,'00:00:18',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('When They Come for Me',5,5,'00:04:53',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Robot Boy',6,5,'00:04:29',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Jornada del Muerto',7,5,'00:01:34',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Waiting for the End',8,5,'00:03:51',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Blackout',9,5,'00:04:39',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Wretches and Kings',10,5,'00:04:15',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Wisdom, Justice, and Love',11,5,'00:01:38',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Iridescent',12,5,'00:04:56',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Fallout',13,5,'00:01:23',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('The Catalyst',14,5,'00:05:39',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('The Messenger',15,5,'00:03:01',1);

insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('The Requiem',1,6,'00:02:01',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('The Radiance',2,6,'00:00:57',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Burning in the Skies',3,6,'00:04:13',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Empty Spaces',4,6,'00:00:18',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('When They Come for Me',5,6,'00:04:53',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Robot Boy',6,6,'00:04:29',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Jornada del Muerto',7,6,'00:01:34',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Waiting for the End',8,6,'00:03:51',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Blackout',9,6,'00:04:39',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Wretches and Kings',10,6,'00:04:15',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Wisdom, Justice, and Love',11,6,'00:01:38',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Iridescent',12,6,'00:04:56',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Fallout',13,6,'00:01:23',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('The Catalyst',14,6,'00:05:39',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('The Messenger',15,6,'00:03:01',1);

insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Papercut  ',1,7,'00:03:04', 1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('One Step Closer  ',2,7,'00:02:35',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('With You  ',3,7,'00:03:23',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Points of Authority',4,7,'00:03:20',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Crawling  ',5,7,'00:03:29',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Runaway  ',6,7,'00:03:03',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('By Myself  ',7,7,'00:03:09',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('In the End  ',8,7,'00:03:36',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('A Place for My Head  ',9,7,'00:03:04',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Forgotten  ',10,7,'00:03:14',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Cure for the Itch ',11,7,'00:02:37',1);
insert into musicas(mscnome, mscfaixa, mscdisco, mscduracao, mscbanda ) values('Pushing me Away  ',12,7,'00:03:11',1);


/*--------------------------------------------------------- Kard 4------------------------------------------------------------------------------------------*/

-- Ride on the Wind
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Humming', 1, 8, '00:01:12', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Moonlight', 2, 8,'00:03:20', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Ride On The Wind', 3, 8,'00:02:57', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Knockin On My Heavens Door', 4, 8,'00:03:50', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Dímelo', 5, 8,'00:03:22', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Ride On The Wind (inst.)', 6, 8,'00:02:57', 2);

-- You & Me 
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Into You', 1, 9, '00:03:33', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Trust Me ', 2, 9, '00:04:23', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Push & Pull', 3, 9, '00:03:18', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Jinikka', 4, 9, '00:03:43', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('You In Me', 5, 9, '00:03:24', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Trust Me ', 6, 9, '00:04:36', 2);


-- Lovebird
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Here We Now', 1, 10, '00:03:34', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Afternoon Tea', 2, 10, '00:02:29', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('i-Diary', 3, 10, '00:02:00', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Meal Meal', 4, 10, '00:02:24', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Moonlight', 5, 10,'00:03:32', 2);


-- Hola Hola
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Oh NaNa ', 1, 11, '00:03:27', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Don t Recall', 2, 11, '00:03:29', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Rumor', 3, 11, '00:03:38', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('04. Hola Hola', 4, 11, '00:03:23', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('I Won t Stop', 5, 11, '00:03:49', 2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Living Good', 6, 11, '00:03:36', 2);


/*------------------------------------------------------- Supercombo 3 ------------------------------------------------------------------------------------------*/

-- Rogério
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Magaiver ', 1, 12, '00:03:24', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('A Piscina e o Karma ', 2, 12, '00:03:43', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Bonsai', 3, 12, '00:03:55', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Grão de Areia ', 4, 12, '00:03:52', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Monstros ', 5, 12, '00:04:06', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Embrulho', 6, 12, '00:03:22', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Morar', 7, 12, '00:03:40', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Bomba Relógio ', 8, 12, '00:03:34', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Jovem', 9, 12, '00:03:21', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Eutanásia', 10, 12, '00:03:14', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Rogério', 11, 12, '00:03:35', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Lentes ', 12, 12, '00:03:18', 3);

-- Amianto
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Matagal', 1, 13, '00:02:08', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Campo de Força', 2, 13, '00:03:39', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Piloto Automático', 3, 13, '00:03:17', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Menino', 4, 13, '00:02:41', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Sol da Manhã', 5, 13, '00:04:11', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('O Peso da Cruz', 6, 13, '00:03:45', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Ela', 7, 13, '00:03:24', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Fundo do Mar', 8, 13, '00:03:24', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Soldadinho', 9, 13, '00:03:52', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Memorial', 10, 13, '00:04:11', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Autonomia', 11, 13, '00:03:20', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Amianto', 12,13 , '00:04:17', 3);

-- Sal Grosso
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Desabafo ', 1, 14, '00:01:29', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Se Eu Quiser', 2, 14, '00:03:23', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Chuva de Granito', 3, 14, '00:03:32', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Não Dá Certo', 4, 14, '00:03:33', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Mulher da Vida', 5, 14, '00:03:43', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Saco Cheio', 6, 14, '00:03:36', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Como são as Coisas', 7, 14, '00:03:54', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Faz Parte', 8, 14, '00:03:38', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Por Essa Eu Não Esperava', 9, 14, '00:04:00', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Anestesia', 10, 14, '00:03:36', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Vê Se Não Morre', 11, 14, '00:03:53', 3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Oculto', 12, 14, '00:03:20', 3);

/*------------------------------------------------------- CodPaly 2 ------------------------------------------------------------------------------------------*/

-- Ghost Stories
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Always In My Head', 1, 15, '00:03:37', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Magic', 2, 15, '00:04:45', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Ink', 3, 15, '00:03:48', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('True Love', 4, 15, '00:04:06', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Midnight', 5, 15, '00:04:50', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Anothers Arms', 6, 15, '00:03:55', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Oceans', 7, 15, '00:05:22', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('A Sky Full of Stars', 8, 15, '00:04:29', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('O', 9, 15, '00:07:47', 4);

-- Parachutes
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Dont Panic', 1, 16, '00:02:17', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Shiver', 2, 16, '00:05:00', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Spies', 3, 16, '00:05:19', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Sparks', 4, 16, '00:03:47', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Yellow', 5, 16, '00:04:29', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Trouble', 6, 16, '00:04:31', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Parachutes', 7, 16, '00:00:46', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('High Speed', 8, 16, '00:04:14', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('We Never Change', 9, 16, '00:04:09', 4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Everything s Not Lost', 10, 16, '00:07:16', 4);

/*-------------------------------------------------------- Kaleo 1------------------------------------------------------------------------------------------*/

-- A/B
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('No Good', 1, 17, '00:03:54', 5);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Way Down We Go', 2, 17, '00:03:34', 5);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Broken Bones', 3, 17, '00:04:06', 5);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Glass House', 4, 17, '00:04:01', 5);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Hot Blood', 5, 17, '00:03:39', 5);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('All The Pretty Girls', 6, 17, '00:04:30', 5);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Automobile', 7, 17, '00:03:07', 5);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Vor í Vaglaskógi', 8, 17, '00:04:37', 5);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('Save Yourself', 9, 17, '00:04:34', 5);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCBANDA) VALUES ('I Can t Go On Without You', 10, 17, '00:06:13', 5);

/*-------------------------------------------------------- Emicida 3 ------------------------------------------------------------------------------------------*/

-- 10 anos de triunfo
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Bang ', 1, 18, '00:05:54', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Gueto / Os Mlk é Liso ', 2, 18, '00:03:25', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('I Love Quebrada ', 3, 18, '00:03:19', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('A Chapa é Quente ', 4, 18, '00:04:09', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('A Cada Vento ', 5, 18, '00:05:13', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Oásis ', 6, 18, '00:03:55', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Alma Gêmea ', 7, 18, '00:04:03', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Mãe ', 8, 18, '00:04:58', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Ooorra ', 9, 18, '00:04:45', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Nóiz ', 10, 18, '00:02:19', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Boa Esperança ', 11, 18, '00:03:20', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Levanta e Anda ', 12, 18, '00:03:12', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Rinha ', 13, 18, '00:02:12', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Triunfo ', 15, 18, '00:04:19', 24);

-- O glorioso retorno de quem nunca esteve aqui
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Milionário do sonho', 1, 19, '00:00:50', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Levanta e anda', 2, 19, '00:02:30', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Nóiz', 3, 19, '00:05:03', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Zóião', 4, 19, '00:03:53', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Crisântemo', 5, 19, '00:05:17', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Sol de giz de cera', 6, 19, '00:02:18', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Hoje cedo', 7, 19, '00:03:14', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Trepadeira', 8, 19, '00:04:43', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Bang!', 9, 19, '00:04:51', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Gueto', 10, 19, '00:03:04', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Hino vira-lata', 11, 19, '00:03:12', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Alma gêmea', 12, 19, '00:04:00', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Samba do fim do mundo', 13, 19, '00:03:39', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Ubuntu fristili', 14, 19, '00:04:47', 24);

-- Pra quem já mordeu um cachorro por comida, até que eu cheguei longe...
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('E. M. I. C. I. D. A.', 1, 20, '00:03:25', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Sozim', 2, 20, '00:03:14', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Rotina', 3, 20, '00:02:51', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Ainda Ontem', 4, 20, '00:03:37', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Só Isso', 5, 20, '00:03:52', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Vou Buscar Minha Fulô', 6, 20, '00:01:24', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Ela Diz', 7, 20, '00:03:30', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Por Deus, por Favor', 8, 20, '00:03:02', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('A Cada Vento', 9, 20, '00:03:28', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Sei Lá', 10, 20, '00:03:46', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Cidadão', 11, 20, '00:01:26', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Soldado Sem Bandeira', 12, 20, '00:03:30', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Um, Dois, Três, Quatro', 13, 20, '00:00:40', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Fica Mais um Pouco Amor', 14, 20, '00:02:27', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Eu Tô Bem', 15, 20, '00:03:19', 24);

/*-------------------------------------------------------- Rubel 2 ------------------------------------------------------------------------------------------*/

-- Casas
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Colégio', 1, 21, '00:03:45', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Cachorro', 2, 21, '00:03:44', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Pinguim', 3, 21, '00:04:47', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Casquinha', 4, 21, '00:02:33', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Batuque', 5, 21, '00:00:29', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Mantra (feat. Emicida)', 6, 21, '00:04:54', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Passagem', 7, 21, '00:01:13', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Explodir', 8, 21, '00:04:56', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Sapato', 9, 21, '00:04:17', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Chiste (feat. Rincon Sapiência)', 10, 21, '00:02:37', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Fogueira', 11, 21, '00:01:04', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Partilhar', 12, 21, '00:05:37', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Santana', 13, 21, '00:06:56', 24);

-- Pearl
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('O Velho e o Mar', 1, 22, '00:04:12', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Mascarados', 2, 22, '00:03:44', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Pearl', 3, 22, '00:04:02', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Quando Bate Aquela Saudade', 4, 22, '00:06:35', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Ben', 5, 22, '00:02:58', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Nuvem', 6, 22, '00:03:24', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Quadro Verde', 7, 22, '00:07:03', 24);

/*------------------------------------------------------- Harry Styles 1 ------------------------------------------------------------------------------------------*/

-- Harry Styles
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Meet Me in the Hallway', 1, 23, '00:03:47', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Sign Of The Times', 2, 23, '00:05:40', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Carolina', 3, 23, '00:03:09', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Two Ghosts', 4, 23, '00:03:49', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Sweet Creature', 5, 23, '00:03:45', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Only Angel', 6, 23, '00:04:51', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Kiwi', 7, 23, '00:02:56', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Ever Since New York', 8, 23, '00:04:13', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Woman', 9, 23, '00:04:38', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('From the Dining Table', 10, 23, '00:03:31', 24);

/*-------------------------------------------------------- Avicii 2 ------------------------------------------------------------------------------------------*/

-- Stories
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Waiting For Love', 1, 24, '00:03:50', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Talk to Myself', 2, 24, '00:03:55', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Touch Me', 3, 24, '00:03:06', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Ten More Days', 4, 24, '00:04:05', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('For a Better Day', 5, 24, '00:03:26', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Broken Arrows', 6, 24, '00:03:52', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('True Believer', 7, 24, '00:04:48', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('City Lights', 8, 24, '00:06:28', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Pure Grinding', 9, 24, '00:02:51', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Sunset Jesus', 10, 24, '00:04:24', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Can’t Catch Me', 11, 24, '00:03:59', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Somewhere in Stockholm', 12, 24, '00:03:22', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Trouble', 13, 24, '00:02:51', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Gonna Love Ya', 14, 24, '00:03:35', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('The Nights', 15, 24, '00:02:56', 24);

-- True
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Wake Me Up', 1, 25, '00:04:08', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('You Make Me', 2, 25, '00:03:53', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Hey Brother', 3, 25, '00:04:15', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Addicted To You', 4, 25, '00:02:29', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Dear Boy', 5, 25, '00:07:59', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Liar Liar', 6, 25, '00:03:59', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Shame On Me', 7, 25, '00:04:14', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Lay Me Down', 8, 25, '00:05:00', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Hope There s Someone', 9, 25, '00:06:21', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Heart Upon My Sleeve', 10, 25, '00:04:43', 24);

/*------------------------------------------------------- Lady Gaga 2 ------------------------------------------------------------------------------------------*/

-- Joanne
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Diamond Heart', 1, 26, '00:03:30', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('A-Yo', 2, 26, '00:03:27', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Joanne', 3, 26, '00:03:16', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('John Wayne', 4, 26, '00:02:54', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Dancin in Circles', 5, 26, '00:03:27', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Perfect Illusion', 6, 26, '00:03:02', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Million Reasons', 7, 26, '00:03:25', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Sinner s Prayer', 8, 26, '00:03:43', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Come to Mama', 9, 26, '00:04:14', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Hey Girl', 10, 26, '00:04:15', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Angel Down', 11, 26, '00:03:49', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Grigio Girls', 12, 26, '00:03:00', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Just Another Day', 13, 26, '00:02:58', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Angel Down (work tape)', 14, 26, '00:02:19', 24);

-- The Fame
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Just Dance', 1, 27, '00:04:02', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('LoveGame', 2, 27, '00:03:36', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Paparazzi', 3, 27, '00:03:29', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Poker Face', 4, 27, '00:03:58', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Eh, Eh (Nothing Else I Can Say)', 5, 27, '00:02:57', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Beautiful, Dirty, Rich', 6, 27, '00:02:53', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('The Fame', 7, 27, '00:03:43', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Money Honey', 8, 27, '00:02:51', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Starstruck', 9, 27, '00:03:37', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Boys Boys Boys', 10, 27, '00:03:21', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Paper Gangsta', 11, 27, '00:04:23', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Brown Eyes', 12, 27, '00:04:04', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('I Like It Rough', 13, 27, '00:03:23', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Summerboy', 14, 27, '00:04:14', 24);

/*------------------------------------------------------- Rihanna 2 ------------------------------------------------------------------------------------------*/

-- Anti
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Consideration', 1, 28, '00:02:41', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('James Joint', 2, 28, '00:01:12', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Kiss it Better', 3, 28, '00:04:13', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Work', 4, 28, '00:03:39', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Desperado', 5, 28, '00:03:06', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Woo', 6, 28, '00:03:56', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Needed Me', 7, 28, '00:03:12', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Yeah, I Said It', 8, 28, '00:02:13', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Same Ol’ Mistakes', 9, 28, '00:06:37', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Never Ending', 10, 28, '00:03:23', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Love On The Brain', 11, 28, '00:03:44', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Higher', 12, 28, '00:02:01', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Close to You', 13, 28, '00:03:43', 24);

-- Loud
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('S&M', 1, 29, '00:04:03', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('What s My Name?', 2, 29, '00:04:23', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Cheers (Drink to That)', 3, 29, '00:04:22', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Fading', 4, 29, '00:03:20', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Only Girl (In the World)', 5, 29, '00:03:55', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('California King Bed', 6, 29, '00:04:12', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Man Down', 7, 29, '00:04:27', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Raining Men', 8, 29, '00:03:45', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Complicated', 9, 29, '00:04:18', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Skin', 10, 29, '00:05:04', 24);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCDURACAO, MSCARTISTA) VALUES ('Love the Way You Lie (Part II)', 11, 29, '00:04:56', 24);


-- select * from musicas;

-- drop database play;
