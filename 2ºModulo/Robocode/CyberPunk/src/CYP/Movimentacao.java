package CYP;

import robocode.ScannedRobotEvent;


public class Movimentacao {

	public boolean fugindoX;
	public boolean fugindoY;
	boolean mover;
	double vidaDoInimigo;
	double dano;
	double veloInimigo;

	public int i = 1;

	public Movimentacao() {

		fugindoX = false;//fugindo inicia como false
		fugindoY = false;
	}

	public void movimentos(CyberPunk robo, ScannedRobotEvent inimigo, double bala) {

		if (bala >= 1) {
			dano = 2 * (bala - 1);//Calculo do dano da minha bala para testar se acerta o inimigo de acordo com a vida dele
		} else {
			dano = 4 * bala;
		}
		
		robo.setAhead((inimigo.getDistance() - 80) * i);//movimentação inicial
		robo.setTurnRight(inimigo.getBearing() - 90);

		/*
		 * Quando o inimigo perder vida, quer dizer que ele atirou Então ele vai pra
		 * direção oposta que estiver indo atualmente para poder desviar dos tiros
		 */

		if (vidaDoInimigo - inimigo.getEnergy() != Math.abs(inimigo.getVelocity() - veloInimigo) * 0.5 - 1) {//não bateu na parede

			if (inimigo.getEnergy() < vidaDoInimigo && !robo.acertou) {// está comparando se a vida atual é menor que a
																		// vida
																		// que foi guardada antes e eu não
																		// acertei(false)
				if (!fugindoX && !fugindoY) {// ele só entrará no if se não estiver se distanciando do robô inimigo
					i *= -1; // irá ao contrário da direção atual
				}
			} else {
				robo.acertou = false;// se ele acertar, volta como falso e entra no if a cima se eu não acertar de
										// novo
			}
		}

		if (inimigo.getEnergy() <= 40 && robo.getEnergy() > inimigo.getEnergy()) {// se o inimigo tiver 40 de vida, o
																					// robô chega mais perto
			if (i > 0) {
				robo.setTurnRight(inimigo.getBearing() - 60); // mantendo o grau de 60 lateral
			} else {
				robo.setTurnRight(inimigo.getBearing() - 120); // mantendo o grau de 120 lateral
			}
		}

		if (inimigo.getDistance() <= 150) { //se a distancia form menor e igual 150

			if (!fugindoX && !fugindoY) {// e não estiver fugindo

				if (i > 0) {
					robo.setTurnRight(inimigo.getBearing() - 120); // mantendo o grau de 120 lateral
				} else {
					robo.setTurnRight(inimigo.getBearing() - 60); // mantendo o grau de 60 lateral
				}
			}
		}

		if ((robo.getX() > robo.getBattleFieldWidth() - 50 || robo.getX() < 0 + 50)) {// se chegar a 50px da parede
																						// lateral
			if (!fugindoX) {// e não estiver fugindo da parede

				i *= -1; // ir a direção ao contrário da atual
			}

			fugindoX = true; //retorna true caso detectar a parede
		} else {

			fugindoX = false;//se não, retorna falso
		}

		if ((robo.getY() > robo.getBattleFieldHeight() - 50 || robo.getY() < 0 + 50)) { // se chegar a 50px da parede de
																						// cima

			if (!fugindoY) {// e não estiver fugindo da parede

				i *= -1; // ir a direção ao contrário da atual
			}

			fugindoY = true; // retorna true quando estiver fugindo
		} else {

			fugindoY = false; // retorna false se não esiver fugindo
		}

		/*
		 * Para não ficar preso entre uma quina e o inimigo o if tá pegando a parede x e
		 * y comparando pra ver se as duas não estão dando o mesmo valor(quina) e a
		 * distancia do inimigo em relação a você...
		 */
		if ((robo.getX() > robo.getBattleFieldWidth() - 150 || robo.getX() < 0 + 150)
				&& (robo.getY() > robo.getBattleFieldHeight() - 150 || robo.getY() < 0 + 150)
				&& inimigo.getDistance() < 10000) {

			if (i > 0) {
				robo.setTurnRight(inimigo.getBearing() - 60); // mantendo o grau de 60 lateral
			} else {
				robo.setTurnRight(inimigo.getBearing() - 120); // mantendo o grau de 120 lateral
			}
		}
		
		vidaDoInimigo = inimigo.getEnergy();// está guardando a vida atual do inimigo na variável
		veloInimigo = inimigo.getVelocity(); // está guardando a velocidade do inimigo
		
	}

}