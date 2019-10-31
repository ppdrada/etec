package Conta;

public class Conta {
	private String titular;
	private  double saldo;
	
	public Conta(String titular,double saldo) {
		
		this.setTitular(titular);
		this.setSaldo(saldo);
		
	}

	public String getTitular() {
		return titular;
	}

	public void setTitular(String titular) {
		this.titular = titular;
	}

	public double getSaldo() {
		return saldo;
	}

	public void setSaldo(double saldo) {
		this.saldo = saldo;
	}
	
	public void VerificarSaldo() {
		//Escrever o valor do Saldo
		System.out.println("Seu saldo é" + saldo);
		
	}
	
	public void Desconto(double valor) {
		//Receber o valor e efetua um Desconto de 0,1% de Taxa
		saldo = saldo * 0.1 / 100; 
	}

}
