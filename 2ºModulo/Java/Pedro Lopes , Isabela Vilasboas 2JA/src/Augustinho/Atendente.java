package Augustinho;
public class Atendente extends Funcionario{

	private String setor;
	
	public Atendente(String nome, int idade, int dependete_qtd, double salario, String setor) {
		super(nome, idade, dependete_qtd, salario);
		this.setor = setor;
	}
	
	public double  calculoSalario() {
		return getSalario() + 500 * getDependente_qtd();
	}
	
	public void getInfo() {
		
		System.out.println("\nNome: " + getNome());
		System.out.println("Idade: " + getIdade());
		System.out.println("Dependente: " + getDependente_qtd());
		System.out.println("Setor: " + this.setor);
		System.out.println("Salário: " + calculoSalario());
	}
}


