package Conta;

public class Contacorrente extends Conta{
	
	 private String nomecc; 

	public Contacorrente(String titular, double saldo, String nomecc) {
		super(titular, saldo);
		
		this.setNomecc(nomecc);
	}

	public String getNomecc() {
		return nomecc;
	}

	public void setNomecc(String nomecc) {
		this.nomecc = nomecc;
	}
	

}
