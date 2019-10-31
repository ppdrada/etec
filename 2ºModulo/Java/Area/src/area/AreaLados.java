package area;

public class AreaLados {
	private String nome;
	private double lado1;
	private double lado2;
	private double lado3;
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public double getLado1() {
		return lado1;
	}
	public void setLado1(double lado1) {
		this.lado1 = lado1;
	}
	public double getLado2() {
		return lado2;
	}
	public void setLado2(double lado2) {
		this.lado2 = lado2;
	}
	public double getLado3() {
		return lado3;
	}
	public void setLado3(double lado3) {
		this.lado3 = lado3;
	}
	
	public AreaLados(String nome,double lado1, double lado2, double lado3 ) {
		this.nome = nome;
		this.lado1 = lado1;
		this.lado2 = lado2;
		this.lado3 = lado3;
		
	}

	public double Calculos()
	{
		
		if(nome == "circulo") {
			
			return Math.PI*(lado1 * lado1);
		}
		if(nome == "quadrado") 
		{
			return lado1*lado2;
		}
		
		
		if(nome == "retangulo") {
			 return lado1*lado2;
			
		}
		
		
		return 0;
		
	}
}

