
public class Equipe extends Pessoa {

	private String projeto;
	private int qtdFilhos;

	public Equipe(String projeto, int qtdFilhos, String nome, String cpf, int idade, double salario) {
		super(nome, cpf, idade, salario);

		this.qtdFilhos = qtdFilhos;
		this.projeto = projeto;
	}

	public double valorFilhos(){

		int qtd = qtdFilhos < 3 ? qtdFilhos : 3; 

		return getSalario() + getSalario() * qtd / 100;
	}


	
	public String getProjeto() {
		return projeto;
	}

	public double calcular() {
		return getSalario() + getSalario() * 8/100 + valorFilhos() ;
	}
	
	
	public void imprimir(){
		
		System.out.println("Gerente");
		System.out.println("Nome: " + this.getNome());
		System.out.println("CPF: " + this.getCpf());
		System.out.println("Idade: " + this.getIdade() + " anos");
		System.out.println("Salário: R$" + String.format("%.2f", calcular()));
		System.out.println("Projeto: " + this.getProjeto());
		System.out.println("Filhos: " + this.getQtdFilhos() + " filhos");
	}

	public int getQtdFilhos() {
		return qtdFilhos;
	}
}
