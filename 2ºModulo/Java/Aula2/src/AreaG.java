
public class AreaG {
	private String Nome ;
	private double LadoA;
	private double LadoB; 
	private double LadoC; 
	public void CalculaArea() {
		double resu = 0;
		double Pi = 3.14;
		
		
		if (Nome.equals("Quadrado") && LadoA == LadoB) {
			resu = LadoA*LadoB;
		}
		else {	
			resu = LadoA*LadoB;
		}
		if (Nome.equals("Circulo")) {
			resu =  3.14 * (LadoA*LadoA);
		}
		if(Nome.equals( "Trapézio")) {
			resu = (LadoA+LadoB)/2*LadoC;
		
		}
		System.out.println("A Area do " + Nome + " É; " + resu);
	}
	public AreaG(String Nome, double LadoA, double LadoB) {
		// TODO Auto-generated constructor stub
		this.Nome = Nome;
		this.LadoA = LadoA;
		this.LadoB = LadoB;
		this.LadoC = 0;
	}
	
	public AreaG(String Nome, double LadoA) {
		// TODO Auto-generated constructor stub
		this.Nome = Nome;
		this.LadoA = LadoA;
		this.LadoB = 0;
		this.LadoC = 0;
	}
	
	public AreaG(String Nome, double LadoA, double LadoB, double LadoC) {
		// TODO Auto-generated constructor stub
		this.Nome = Nome;
		this.LadoA = LadoA;
		this.LadoB = LadoB;
		this.LadoC = LadoC;
	}

}

