package Augustinho;

public class Gerente extends Funcionario{

	private String setor_responsavel;
	
	public Gerente(String nome, int idade, int dependente_qtd, double salario, String setor_responsavel) {
		super(nome, idade,dependente_qtd,salario);
		this.setor_responsavel = setor_responsavel;
	}
	
	public double adicional() {
		return calculoInss() + 600;
	}
	
	public void getInfo() {
		
		System.out.println("\nNome: " + getNome());
		System.out.println("Idade: " + getIdade());
		System.out.println("Dependente: " + getDependente_qtd());
		System.out.println("Setor responsável: " + this.setor_responsavel);
		System.out.println("Salário: " + getSalario());
		System.out.println("Adicional: " + adicional());
	}
}
	
	


