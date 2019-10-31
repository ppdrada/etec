
public class Chefe extends Funcionario{
	private double graticacaoChefia;
	
	public Chefe(String matricula, double salarioBase, double gratificacaoProd, double graticacaoChefia) 
	{
		super( matricula, salarioBase,gratificacaoProd);
		this.graticacaoChefia = graticacaoChefia;
	}

	public double getGraticacaoChefia() {
		return graticacaoChefia;
	}

	public void setGraticacaoChefia(double graticacaoChefia) {
		this.graticacaoChefia = graticacaoChefia;
	}
	
	///////////////////////////////////
	
	public double fonecaSalarioBruto()
	{
		double salarioBruto = getSalarioBase() + getGratificacaoProd();
		return salarioBruto + getGraticacaoChefia();
	}
	
	public double fonecaDesconto(double fonecaDesconto)
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
	
	public double fomecaSalarioLiquido()
	{
		return fonecaSalarioBruto() - fonecaDesconto(0);
	}
	
	
}
