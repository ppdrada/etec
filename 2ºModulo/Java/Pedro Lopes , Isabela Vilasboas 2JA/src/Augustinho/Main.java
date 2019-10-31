package Augustinho;

public class Main {

	public static void main(String[] args) {
		
		Atendente pedrita = new Atendente("Pedrita",17,01,350.00, "Vendas");
		Atendente isao = new Atendente("Isão do caminhão",16,02,350.00, "Vendas");
		
		pedrita.getInfo();
		isao.getInfo();

	}

}
