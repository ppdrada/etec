create database Produtos;

	use Produtos;

create table ProdutoDaLoja(
ID_Produto int primary key auto_increment not null,
imgProd varchar(50) not null,
NomeProd varchar(50),
SubtProd varchar(100),
DescricaoProd Varchar(250),
PrecoProd double not null
);

insert into ProdutoDaLoja(ID_Produto, imgProd, NomeProd, SubtProd, DescricaoProd, PrecoProd) 
	values(01,'Atari.jpg', 'Chatari 2600', 'Console para jogos', 'Brinque seus filhos como exclusivo desenho ergonômico, proporcionando pelos controles unidirecionais desenvolvidos pela NASA. Muita ação diversão no seu lar!', 3200.00);
    
insert into ProdutoDaLoja(ID_Produto, imgProd, NomeProd, SubtProd, DescricaoProd, PrecoProd) 
	values(02,'Rosa.jpg', 'Casa Rosada', 'Se sua família necessitade espaço, mas o luxo da cidade é um inconveniente, adquira já a nossa CASA ROSADA. Disponível nas versões Chácara, Fazenda e Grilagem', 345700.51);
    
insert into ProdutoDaLoja(ID_Produto, imgProd, NomeProd, SubtProd, DescricaoProd, PrecoProd) 
	values(03,'Tubo.jpg', 'YouTubo', 'Tubo de PVC ¾ de polegada', 'Os tubos e conexões da linha  YOUTUBE, da Onça, são indicados para uso interno (dentro de paredes) e externo (como itens decorativo de jardim). Permite ligaçoes de água (fria ou quente), gás e resíduos químicos.', 7.30);
    
insert into ProdutoDaLoja(ID_Produto, imgProd, NomeProd, SubtProd, DescricaoProd, PrecoProd) 
	values(04,'Noya.jpg', 'Noya N2005', 'Aparelho', 'Adquira já este fantástico aparelho! Experimente andar pela cidade com o GPS integrado, navegar na internet, usar o banheiro enquanto joga Elge Of Impares ou  curtir um som estérico em qualquer ônibus da cidade.', 1800.75);
    
insert into ProdutoDaLoja(ID_Produto, imgProd, NomeProd, SubtProd, DescricaoProd, PrecoProd) 
	values(05,'Ursos.jpg', 'Teds protetores', 'Ursinhos carinhosos que te protegem de todo o mal', 'Brinque seus filhos como exclusivo desenho ergonômico, proporcionando pelos controles unidirecionais desenvolvidos pela NASA. Muita ação diversão no seu lar!', 000.00);
  
insert into ProdutoDaLoja(ID_Produto, imgProd, NomeProd, SubtProd, DescricaoProd, PrecoProd) 
	values(06,'Pilula.jpg', 'Tradutor Urniversal', 'Quem nunca teve dificuldade de aprender alguma lingua nova, ou teve o sonhe de falar com algum animal. Agora você pode com o Tradutor Universal.', 000.00);
 
select * from ProdutoDaLoja;

drop table ProdutoDaLoja;
