
public class Funcionario {
	private String matricula;
	private double salarioBase;
	private double gratificacaoProd;
	
	public Funcionario(String matricula, double salarioBase, double gratificacaoProd)
	{
		this.matricula = matricula;
		this.salarioBase = salarioBase;
		this.gratificacaoProd = gratificacaoProd;

	}
	public String getMatricula() {
		return matricula;
	}

	public void setMatricula(String matricula) {
		this.matricula = matricula;
	}

	public double getSalarioBase() {
		return salarioBase;
	}

	public void setSalarioBase(double salarioBase) {
		this.salarioBase = salarioBase;
	}
	public double getGratificacaoProd() {
		return gratificacaoProd;
	}
	public void setGratificacaoProd(double gratificacaoProd) {
		this.gratificacaoProd = gratificacaoProd;
	}

	public double fonecaDesconto(double fonecaDesconto)// Desconco com Base no Imposto de Renda
	{
		if(getSalarioBase() <= 1000)//Inseto
		{
			fonecaDesconto = 0;
		}
		
		if(getSalarioBase() > 1000 && getSalarioBase() <= 1800) //10% 
		{
			fonecaDesconto = getSalarioBase() * 0.90 - 100; 
		}
		
		if(getSalarioBase() > 1800) //25%
		{
			fonecaDesconto = getSalarioBase() * 0.75 - 370;
		}
		return fonecaDesconto;
	}
	
	
	public double fonecaSalarioLiquido()
	{
		return fonecaSalarioBruto() + getGratificacaoProd() - fonecaDesconto(0);
	}
	
	public double fonecaSalarioBruto()
	{
		return getSalarioBase() + getGratificacaoProd();
	}

}
