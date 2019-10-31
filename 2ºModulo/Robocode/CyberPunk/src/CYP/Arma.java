package CYP;

import static robocode.util.Utils.normalRelativeAngleDegrees;

import robocode.ScannedRobotEvent;

public class Arma {

	public double inimigoHeading;
	public double bala;

	//configura o canhão para seguir o radar
	public void seguirRadar(CyberPunk robo) {

		robo.setTurnGunRight(anguloRadar(robo)); // vira o canhão até o radar
	}

	// retorna o angulo do radar
	public double anguloRadar(CyberPunk robo) {

		double angulo = robo.getRadarHeading() - robo.getGunHeading(); // diferença entre o angulo do canhão e do radar
		return normalRelativeAngleDegrees(angulo); // retorna angulo relativo
	}

	// atiraaa
	public void atirar(CyberPunk robo, ScannedRobotEvent inimigo, double tempo) {

		Calculos calculos = new Calculos(); // classe que faz calculos mais complexos

		// se achou um padrão...
		if (Padrao.conferirPadrao(robo, inimigo)) {

			System.out.println("Reconheci o padrão - " + Padrao.getPadroesReconhecidos()); // mostra se reconheceu o padrão
			
			// vira o canhão para o angulo do radar mais o angulo onde o inimigo vai estar
			robo.setTurnGunRight(normalRelativeAngleDegrees(anguloRadar(robo)
					+ calculos.anguloFrentePadrao(robo, inimigo)));
			
			//robo.setFire(calculos.poderDaBala(inimigo.getDistance(), tempo)); // calcula o poder da bala e atira

		} else { //se não achou...

			// vira o canhão para o angulo do radar mais o angulo onde o inimigo vai estar
			robo.setTurnGunRight(
					normalRelativeAngleDegrees(anguloRadar(robo) + calculos.anguloFrente(inimigo, tempo, robo)));
		}

		robo.setFire(calculos.poderDaBala(inimigo.getDistance(), tempo)); // calcula o poder da bala e atira

		bala = calculos.poderDaBala(inimigo.getDistance(), tempo);// pegando a potencia da nossa bala

		Padrao.addDados((int) inimigo.getVelocity(), inimigo.getHeadingRadians(),
				(int) (inimigo.getHeading() - inimigoHeading)); // adiciona os dados na classe responsavel em guardar o padrão do inimigo.

		inimigoHeading = inimigo.getHeading(); //guarda o heading atual na variavel para calcular a diferença com o proximo heading
	}
}
