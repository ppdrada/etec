/**
 * main
 */
public class main {

    public static void main(String[] args) {
        
    	Equipe pedroca = new Equipe("Construir um templo", 
    			2, "Pedro Lopes", "476.469.918-48", 17, 50000);
    	Gerente isabela = new Gerente(1, "Isabela Vilasboas", "483.405.788-78", 16, 150000);
        

        
    	isabela.imprimir();
    	pedroca.imprimir();
        
    }
}