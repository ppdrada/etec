package Biblioteca;

public class Principal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
	
		
	Venda LivroVenda = new Venda("As Cronicas de Nárnia","9788533622104","Clive Staples Lewis","Geoffrey Bles","Literatura fantástica", "2000",
			"10-05-20018", "Casas bahia",	100, 15, 35, 10, 8, 32);
	
	LivroVenda.getvenda();
	
		
      
      Aluguel LivroAluguel = new Aluguel("As Cronicas de Nárnia","9788533622104","Clive Staples Lewis","Geoffrey Bles","Literatura fantástica","2000",
    		  "Saraiva", 0, 6, 10 , 8,2019,18, 0); 
      // Os valores do valor da locação e Dia de devolução devem ser alterador direto da classe Aluguel no método getAluguel,
      //tentei fazer pelo metodo contrutor, mas infelimente não consegui 
      LivroAluguel.getAluguel(); 
      
      
      
	}
	
	
	
}
