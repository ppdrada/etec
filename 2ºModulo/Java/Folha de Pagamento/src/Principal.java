
public class Principal {

	public static void main(String[] args) {
		
		System.out.println(" \nFuncionario" );
		Funcionario funcionario = new Funcionario("Pedro", 2022.00, 907);// Matricula, SalarioB, Gratificação
		System.out.println(
		"\nMatricula: " + funcionario.getMatricula() 
		+"\nSalario Bruto: " + funcionario.fonecaSalarioBruto()
		+"\nGratificação: " + funcionario.getGratificacaoProd()+ "\nDesconto: "+ funcionario.fonecaDesconto(0)
		+ "\nSalario Liquido: " + funcionario.fonecaSalarioLiquido());
		
		System.out.println("--------------------------------");
		
		///////
		System.out.println("\nFuncionario cargo de chefia");
		Chefe chefe = new Chefe("Chefe da diretoria ", 23423, 2324, 2234);
		System.out.println( 
		"\n\nMatricula: " + chefe.getMatricula()
		+ "\nSalario Bruto: " + chefe.fonecaSalarioBruto() 
		+"\nGratificação: " + (chefe.getGratificacaoProd()
		+"\nGratificação chefia: " + chefe.getGraticacaoChefia())
		+ "\nDesconto: "+ chefe.fonecaDesconto(0) 
		+ "\nSalario Liquido: " + chefe.fonecaSalarioLiquido());
		
		System.out.println("--------------------------------");
		
		///////
		System.out.println("\nFuncionario de apoio");
		Apoio apoio = new Apoio("TI", 250, 500.00, 5, 234.00);
		System.out.println(
		"\nMatricula: " + apoio.getMatricula()
		+ "\nSalario Bruto: " + apoio.fonecaSalarioBruto() 
		+"\nGratificação: " + apoio.getGratificacaoProd()
		+ "\nNúmero de dependentes: "+ apoio.getNrDependentes() 
		+ "\nAuxilio educação: "+apoio.fonecaAuxEducacao() 
		+"\nSalario Liquido: " + apoio.fonecaSalarioLiquido());
		
	}

}
