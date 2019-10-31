create database lista;
 use lista;
create table operacao(
	codigo int primary key auto_increment
);
INSERT INTO `lista`.`operacoes`
(`codigo`,
`Nome`,
`Foto`,
`data`,
`numero`)
VALUES
(01,
'Terry',
'br',
'2018-05-06',
1);



UPDATE `lista`.`operacoes`
SET
`codigo` = 02,
`Nome` = 'Steban',
`Foto` = 'leao',
`data` = '2018-08-10'>,
`numero` = 2
WHERE `codigo` = 05>;

DELETE FROM `lista`.`operacoes`
WHERE `codigo` = 02;


select * from operacoes;




