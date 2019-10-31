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

create database acervo;
use acervo;

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

-- insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (); 

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
  `DSCANOLANC` year(4) NOT NULL,
  `DSCGRAVADORA` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `discos`
--

-- INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCARTISTA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES
-- (1, 'ORIGINS', 3, NULL, 2018, NULL),
-- (2, 'EVOLVE', 3, NULL, 2017, NULL),
-- (3, 'NIGHT VISIONS', 3, NULL, 2012, NULL);

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
  `ITGDTINI` datetime DEFAULT NULL,
  `ITGDTFIM` datetime DEFAULT NULL,
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

-- insert into paises (pssnome,psssigla) values ('Estados Unidos','USA');
-- insert into paises (pssnome,psssigla) values ('Brasil','Br');


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
  
  
insert into paises (pssnome,psssigla) values ('Estados Unidos','USA');
insert into paises (pssnome,psssigla) values ('Brasil','Br');
insert into paises (pssnome,psssigla) values ('Reino Unido','RU');
insert into paises (pssnome,psssigla) values ('Alemanha','Ale');
  
  


insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (1,'Periphery',2005,1);
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (2,'Milton Nascimento',1967,2); 
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (3,'Makalister',2016,2); 
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (4,'Animal As Leaders',2007,1); 
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (5,'Amy Winehouse',1998,3); 
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (6,'Dream Theater',1985,2); 
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (7,'Ayreon',1995,1); 
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (8,'Pink Floyd',1965,3); 
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (9,'Porcupine Tree',1987,3); 
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (10, ' Vektroid',2005,3);
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (11 ,' Chuck Person', 2009  , 3  ); 
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (12 ,' Chico Buarque',1964  ,  2 );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (13 ,' Mile Davis', 1944 , 1  );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (14 ,' Kraftwerk', 1970 ,  4 );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (15 ,' Depeche Mode', 1980 , 3  );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (16 ,' Genesis', 1967 , 3 );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (17 ,' King Crimson ', 1969 , 3  );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (18 ,' Jethro Tull', 1967 ,  3 );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (19 ,' Wes Montgomery',1958 ,  1 );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (20 ,' Zero 7 ', 1997 , 1  );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (21 ,' Elis & Tom ', 1974 ,  2 );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (22 ,' Steven Wilson ', 1983 , 3  );
insert into bandas (bdscodigo,bdsnome,bdsano,bdspais) values (23 ,' Meshuggah ', 1987 ,  1 );   



INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (1, 'Periphery III: Select Dificult', 1, 2016, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (2, 'Travessia', 2,  1967, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (3, 'Mal dos Trópikos, Construindo a Ponte da Prata Roubada', 3, 2017, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (4, 'Joy Of Motion', 4, 2014, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (5, 'Back To Black', 5, 2006, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (6, 'Octavarium', 6, 2005, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (7, 'The Human Equation', 7, 2004, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (8, 'The Wall ', 8, 1979, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (9, 'Deadwing', 9, 2005, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (10, 'Neo Cali', 10, 2011, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (11 , ' Dark Side Of The Moon ',8 ,1973 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (12 , ' Eccojams Vol.1',11 ,2010 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (13 , ' Construção',12 ,1971 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (14 , ' Bitches Brew', 13 ,1970 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (15 , ' Die Mensch-maschine',14 ,1978 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (16 , ' Violator',15 ,1990, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (17 , ' Metropolis Pt. 2: Scenes from a Memory',6 , 1999, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (18 , ' Foxtrot',16 ,1972 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (19 , ' Nursery Cryme',16 ,1971 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (20 , ' In the Court of the Crimson King',17 , 1969, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (21 , ' Aqualang',18 , 1971, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (22 , ' The Incredible Jazz Guitar of Wes Montgomery',19 ,1960 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (23 , ' Simple Things',20 , 2001, NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (24 , ' Elis & Tom',21 ,1974 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (25 , ' The Raven That Refused to Sing (And Other Stories)',22 ,2013 , NULL);
INSERT INTO `discos` (`DSCCODIGO`, `DSCNOME`, `DSCBANDA`, `DSCANOLANC`, `DSCGRAVADORA`) VALUES (26 , ' The Violent Sleep of Reason',23 ,2016 , NULL);


INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('The Price Is Wrong', 1, 1,1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Motormouth', 2, 1, 1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Marigold', 3, 1, 1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('The Way The News Goes', 4, 1, 1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Remain Indoors', 5, 1, 1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Habitual Line-Stepper', 6, 1, 1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Flatline', 7, 1, 1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Absolomb', 8, 1, 1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Catch Fire', 9, 1, 1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Prayer Position', 10, 1,1);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Lune', 11, 1, 1);



INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Três Pontas', 1, 2,2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Crença', 2, 2,2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Irmão de Fé', 3,2,2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Travessia', 4, 2,2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Canção do Sal', 5, 2,2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Morro Velho', 6, 2,2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Girou Girou', 7, 2,2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Maria Minha Fé', 8, 2,2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Catavento', 9,2,2);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Outubro', 10, 2,2);


INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Quando Observo A Cruz de Folga', 1, 3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Da Era Do Amor Virtual', 2, 3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Synedoche Linhas', 3,3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Sem Fôlego', 4, 3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Corpos De Cera no Incêndio',5,3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Linhas Abissais', 6, 3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('DAZA City', 7, 3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Bobby James', 8, 3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Spice Girls', 9,3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Quandos As Somras Brilharem', 10, 3,3);


INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Ka$cade', 1, 4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Lippincott', 2, 4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Air Chrysalis', 3,4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Another Year', 4, 3,3);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Physical Education ', 5, 4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Tooth and Clow', 6, 4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Crescent', 7, 4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('The Future That Awaited Me', 8, 4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Para MExer', 9,4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('The Woven Web', 10, 4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Mind-Spun', 11, 4,4);
INSERT INTO MUSICAS (MSCNOME, MSCFAIXA, MSCDISCO, MSCBANDA) VALUES ('Nephele', 12, 4,4);

insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Rehab', 1, 5, 5 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('You Know Im No Good', 2, 5, 5 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Me & Mr Jones', 3, 5, 5 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Just Friends', 4, 5, 5 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Back To Black', 5, 5, 5 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Love Is A Losing Game', 6, 5, 5 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Tears Dry On Their Own', 7, 5, 5 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Wake Up Alone', 8, 5, 5 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Some Unholy War', 9, 5, 5 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('He Can Only Hold Her', 10, 5, 5 );



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('The Root of All Evil', 1, 6, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('The Answer Lies Within', 2, 6, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('These Walls', 3, 6, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('I Walk Beside You', 4, 6, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Panic Attack', 5, 6, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Never Enogh', 6, 6, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Sacrificed Sons', 7, 6, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Octavarium', 8, 6, 6 );





insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day One: Vigil', 1, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Two: Isolation', 2, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Three: Pain', 3, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Four: Mystery', 4, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Five: Voices', 5, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Six: CHildhood', 6, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Seven: Hope', 7, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Eight: School', 8, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Nine: Playground', 9, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Ten: Memories', 10, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Eleven: Love', 11, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Twelve: Trauma', 12, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Thirteen: Sign', 13, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Fourteen: Pride', 14, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Fifteen: Betrayal', 15, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Sixteen: Loser', 16, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Seventeen: Accident?', 17, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Eightteen: Realization', 18, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Nineteen: Disclosure', 19, 7, 7 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Day Twenty: Confrontation', 20, 7, 7 );




insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('In The Flesh pt.1', 1, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('The Thin Ice', 2, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Another Brick In The Wall Pt.1', 3, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('The Happiest Days Of Our Lives', 4, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Another Brick In the Wall pt.2', 5, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Mother', 6, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Goodbye Blue Sky', 6, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Empty Spaces', 7, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Young Lust', 8, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('One Of My Turns', 9, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Dont Leave Now', 10, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Another Brick In The Wall pt.3', 11, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Goodbye Cruel World', 12, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Hey You', 13, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Is there Anybody Out There?', 14, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Nobody Home', 15, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Vera', 16, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Bring The Boy Bakc Home', 17, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Comfortably Numb', 18, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('The Show Must Go On', 19, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('in The Flesh pt.2', 20, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Run Like Hell', 21, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Wainting For The worms', 22, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Stop', 23, 8, 8 ); 
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('The Trial', 24, 8, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Outside The Wall', 25, 8, 8 );




insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Deadwing', 1, 9, 9 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Shallow', 2, 9, 9 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Lazarus', 3, 9, 9 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Halo', 4, 9, 9 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Arriving Somewhere But Not Here', 5, 9, 9 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Mellotron Scratch', 6, 9, 9 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Open Car', 7, 9, 9 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Start Os SomeThing Beautiful', 8, 9, 9 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Glass Arm Shattering', 9, 9, 9 );





insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Neo Miami', 1, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Splash', 2, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Calm', 3, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Pak TV', 4, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Untitled', 5, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Skate Club I', 6, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Skate Club II', 7, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Yr Heart', 8, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('yr Mind', 9, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Interlude', 10, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Neo Cali', 11, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Over U', 12, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Softfly', 13, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Terminal', 14, 10, 10 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Tahiti', 15, 10, 10 );



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Speak To Me', 1, 11, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Brathe', 2, 11, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('On The Run', 3, 11, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Time', 4, 11, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('The Great Gig in the Sky', 5, 11, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Money', 6, 11, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Us and Them', 7, 11, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Any Colour You Like', 8, 11, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Brain Damage', 9, 11, 8 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Eclipse', 10, 11, 8 );




insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('A1', 1, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('A2', 2, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('A3', 3, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('A4', 4, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('A5', 5, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('A6', 6, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('A7', 7, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('A8', 8, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('B1', 9, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('B2', 10, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('B3', 11, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('B4', 12, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('B5', 13, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('B6', 14, 12, 11 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('B7', 15, 12, 11 );



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Deus lhe Pague', 1, 13, 12 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Cotidiano', 2, 13, 12 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Desalento', 3, 13, 12 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Construção', 4, 13, 12 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Cordão', 5, 13, 12 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Olha Maria', 6, 13, 12 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Samba De Orly', 7, 13, 12 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Valsinha', 8, 13, 12 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Minha História', 9, 13, 12 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Acalanto', 10, 13, 12 );



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Pharoahs Dance', 1, 14, 13 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Bitches Brew', 2, 14, 13 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Spanish Key',3, 14, 13 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' John McLaughlin ',4, 14, 13 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Mile Runs The Voodoo Down',5, 14, 13 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Sanctuary ',6, 14, 13 );



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values ('Die Roboter ',1, 15, 14 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Spacelab',2, 14, 14 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Metropolis ',3, 14, 14 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Das Model ',4, 14, 14 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Neonlicht',5, 14, 14 );


insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' World In MY Eyes ',1, 15, 15 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Sweet Perfection ',2, 15, 15 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Personal Jesus ',3, 15, 15 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Waiting For THe Night',4, 15, 15 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Enjoy The Silence',5, 15, 15 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Policy of Truth ',6, 15, 15 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Blue Dress',7, 15, 15 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Clean ',8, 15, 15 );


insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Regression', 1, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Overture 1928', 2, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Strange Deja Vu', 3, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Through My Words ', 4, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Fatal Tragedy ', 5, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Beyond This Life', 6, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Through Her Eyes ', 7, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Dance Of Eternity', 8, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' One Last Time', 9, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Spirit Carries On ', 10, 16, 6 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Finally Free ', 11, 16, 6 );



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Watcher Of The Skies ', 1, 17, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Time Table ', 2, 17, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Get em Out By Friday ', 3, 17, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Can-Utility And The Coastliners ', 4, 17, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Horizons ', 5, 17, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Suppers Ready', 6, 17, 16);


insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Musical Box ', 1, 18, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' For Absent Friends ', 2, 18, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Return Of The Giant Hogweed ', 3, 18, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Seven Stones ', 4, 18, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Harold The Barrel ', 5, 18, 16);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Harlequin ', 6,18, 16); 
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Fountain Of Salmacis ', 7,18, 16); 


insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' 21st Century Schizoid Man Including Mirrors ', 1, 19, 17);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' I Talk To The Wind ', 2, 19, 17);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Epitaph Including March For No Reason, Tomorrow and Tomorrow', 3, 19, 17);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Moonchild Including  The Dream, The Ilusion ', 4, 19, 17);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Court Of The Crimson King Including The Return of the Fire Witch,The Dance of the Puppets ', 5, 19, 17);



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Aqualung ', 1, 20,18);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Cross-Eyed Mary ', 2, 20,18);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Cheap Day Return ', 3, 20,18);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Mother Goose ', 4, 20,18);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Wondering Aloud ', 5, 20,18);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Up to Me ', 6, 20,18); 
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' My God ', 7, 20,18); 
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Hymn 43 ', 8, 20,18); 
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Slipstream ', 9, 20,18); 
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Slipstream ', 10, 20,18); 
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Locomotive Breath ', 11, 20,18); 
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Wind Up', 10, 20,18);



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Airegin ', 1,  21, 19 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' D-Natural Blues ', 2,  21, 19 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Polka Dots And MoonBeams ', 3,  21, 19 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Four On Six ', 4,  21, 19 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' West Coast Blues ', 5,  21, 19 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' In Your Own Sweet Way ', 6,  21, 19 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Mister Walker (Renie) ', 7,  21, 19 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Gone With The Wind ', 8,  21, 19 );



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' I Have Seen ', 1,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Polaris ', 2,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Destiny ', 3,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Give It away', 4,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Simple Things ', 5,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Red Dust ', 6,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Distractions ', 7,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' In The Waiting Line ', 8,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Out Of Town ', 9 ,  22,20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' This World ', 10,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Lifukanele ', 11,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' End Theme ', 12 ,  22, 20);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Salt Water Sound ', 13 ,  22, 20 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Spinning ', 14,  22, 20 );



insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Águas de Março ', 1 , 23 ,21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Pois É ', 2,  23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Só Tinha De Ser Com Você ', 3,  23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Modinha ', 4,  23,  21);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Triste ', 5,  23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Corocovado ', 6,  23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' O Que Tinha De Ser ', 7,  23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Retrato Em Branco E Preto ', 8,  23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Brigas Nunca Mais ', 9 , 23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Por Toda Minha Vida ', 10, 23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Fotografia ', 11,  23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Soneto da Separação ', 12 ,23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Chovendo Na Roseira ', 13, 23, 21 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Inútil Paisagem ', 14, 23, 21 );


insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Luminol ', 1 ,  25 ,  18 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Drive Home ', 2 ,  25 ,  22 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Holy Drinker ', 3 ,  25 ,  22 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Pin Drop ', 4 ,  25 ,  22 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Watchmaker ', 5 ,  25 ,  22 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' The Raven That Refused To Sing ', 6 ,  25 ,  22 );


insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Clockworks ', 1 ,  26,  23);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Born In Dissonance ', 2 ,  26 ,  23 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' MonstroCity ', 3 ,  26 ,  23 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' By The Ton ', 4 ,  26 ,  23 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Violent Sleep Of Reason ', 5 ,  26 ,  23 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Ivory Tower ', 6 ,  26 ,  23 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Stifled ', 7 ,  26 ,  23 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Nonstrum ', 8 ,  26 ,  23);
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Our Rage Wont Die ', 9 ,  26 ,  23 );
insert into musicas(mscnome, mscfaixa, MSCDISCO, MSCBANDA) values (' Into Decay ', 10 ,  26,  23 );


insert into gravadoras values (1,'RoadRunner');