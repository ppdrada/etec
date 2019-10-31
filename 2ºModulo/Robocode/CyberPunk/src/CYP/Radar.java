package CYP;

import robocode.ScannedRobotEvent;
import static robocode.util.Utils.normalRelativeAngleDegrees;

public class Radar {

	// configura o radar para procurar o inimigo
	public void procurar(CyberPunk robo) {
		
		robo.setTurnRadarRight(Double.POSITIVE_INFINITY);//ligar o radar no inicio da batalha pra dar um 360 e detectar o inimigo
	}
	
	// configura o radar para seguir o inimigo.
	public void seguirInimigo(CyberPunk robo, ScannedRobotEvent inimigo) {
		
		double angulo = inimigo.getBearing() + robo.getHeading() - robo.getRadarHeading(); //detectando o inimigo em relação ao nosso radar.
		robo.setTurnRadarRight(normalRelativeAngleDegrees(angulo));// angulo detecta a posição lateral do inimigo.
	}
}
