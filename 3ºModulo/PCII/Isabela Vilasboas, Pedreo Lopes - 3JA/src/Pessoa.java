
public class Pessoa {

	private String nome;
	private String cpf;
	private int idade;
	private double salario;
	
	public Pessoa(String nome, String cpf, int idade, double salario) {

		this.nome = nome;
		this.cpf = cpf;
		this.idade = idade;
		this.salario = salario;
	}

	
	public String getNome() {
		return nome;
	}

	
	public String getCpf() {
		return cpf;
	}

	
	public int getIdade() {
		return idade;
	}

	
	public double getSalario() {
		return salario;
	}
}
