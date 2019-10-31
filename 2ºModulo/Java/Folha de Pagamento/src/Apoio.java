
public class Apoio extends Funcionario{
	private int nrDependentes;
	private double valorAuxEducacao;
	
	
	public Apoio(String matricula, double salarioBase, double gratificacaoProd, int nrDependentes, double valorAuxEducacao) 
	{
		super( matricula, salarioBase,gratificacaoProd);
		
		this.nrDependentes = nrDependentes;
		this.valorAuxEducacao = valorAuxEducacao;
		
	}
	
	
	public int getNrDependentes() {
		return nrDependentes;
	}


	public void setNrDependentes(int nrDependentes) {
		this.nrDependentes = nrDependentes;
	}


	public double getValorAuxEducacao() {
		return valorAuxEducacao;
	}


	public void setValorAuxEducacao(double valorAuxEducacao) {
		this.valorAuxEducacao = valorAuxEducacao;
	}
	
	////////////////////////////////
	
	public double fonecaAuxEducacao()
	
	{	
		if ( getNrDependentes() == 1) {
			return 60 + 1* getValorAuxEducacao();
		}
		if ( getNrDependentes() == 2) {
			return  60 + 1* getValorAuxEducacao();
		}
		if ( getNrDependentes() == 3) {
			return  60 + 1* getValorAuxEducacao();
		}
		if ( getNrDependentes() == 4) {
			return  60 + 5* getValorAuxEducacao();
		}
		if ( getNrDependentes() == 5 || getNrDependentes() > 5) {
			return  60 + 5* getValorAuxEducacao();
		}
		
		return  60.00;
	}
	
	public double fonecaSalarioBruto()
	{
		double salarioBruto = getSalarioBase() + getGratificacaoProd();
		return salarioBruto + fonecaAuxEducacao();
	}
	
	
	public double fonecaSalarioLiquido()
	{
		double salarioBruto = getSalarioBase() + getGratificacaoProd() - fonecaDesconto(0);
		return salarioBruto + fonecaAuxEducacao();
	}
	

}
