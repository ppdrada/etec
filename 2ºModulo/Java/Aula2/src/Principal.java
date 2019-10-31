
public class Principal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		AreaG A = new AreaG("Circulo", 8);
		AreaG B = new AreaG("Quadrado", 5, 5);
		AreaG C = new AreaG("Retângulo", 8, 5);
		AreaG D = new AreaG("Trapézio", 2, 2, 2);
		A.CalculaArea();
		B.CalculaArea();
		C.CalculaArea();
		D.CalculaArea();
	}

}
