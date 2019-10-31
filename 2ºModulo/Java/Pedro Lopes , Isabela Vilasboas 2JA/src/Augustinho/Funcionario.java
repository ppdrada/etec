package Augustinho;
public class Funcionario {

	private String nome;
	private int idade;
	private int dependente_qtd;
	private double salario;
	
	public Funcionario(String nome, int idade, int dependente_qtd, double salario) {
		this.nome = nome;
		this.idade = idade;
		this.dependente_qtd = dependente_qtd;
		this.salario = salario;
	}
	
	public double calculoInss() {
		if(salario > 5000) {
			return salario * 0.15;
		}else {
			return salario * 0.10;
		}
	}
	
	public double calculoSalario() {
		return salario + 500 * dependente_qtd;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public int getIdade() {
		return idade;
	}

	public void setIdade(int idade) {
		this.idade = idade;
	}

	public int getDependente_qtd() {
		return dependente_qtd;
	}

	public void setDependente_qtd(int dependente_qtd) {
		this.dependente_qtd = dependente_qtd;
	}

	public double getSalario() {
		return salario;
	}

	public void setSalario(double salario) {
		this.salario = salario;
	}

}
