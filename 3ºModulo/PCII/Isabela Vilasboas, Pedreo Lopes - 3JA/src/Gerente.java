
public class Gerente extends Pessoa {

	private int codGerente;
	
	public Gerente(int codGerente, String nome, String cpf, int idade, double salario) {
		super(nome, cpf, idade, salario);

		this.codGerente = codGerente;
	}

	public double calcular() {
		return getSalario() + getSalario() * 5/100 + gratificacao() ;
	}
	
	
	public double gratificacao() {
		 
		return getSalario() * 0.02;
	}
	
	
	public int getCodGerente() {
		return codGerente;
	}

	public void imprimir(){
		
		System.out.println("Gerente");
		System.out.println("Código: " + this.getCodGerente());
		System.out.println("Nome: " + this.getNome());
		System.out.println("CPF: " + this.getCpf());
		System.out.println("Idade: " + this.getIdade() + " anos");
		System.out.println("Salário: R$" + String.format("%.2f", calcular()));
	}

}
