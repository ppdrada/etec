package CYP;

import robocode.ScannedRobotEvent;

public class Calculos {

	public double velocidadeLateral;

	/**
	 * Calcula o tempo que a bala demora para percorrer uma distância usando a
	 * seguinte fórmula.
	 * 
	 * tempo = distância / velocidade da bala.
	 * 
	 * @param distancia distancia a ser percorrida pela bala.
	 * @param power     potência de disparo da bala.
	 * @return tempo que a bala leva para percorrer determinada distância.
	 */
	public double tempoDaBala(double distancia, double power) {

		return distancia / velocidadeDaBala(power);
	}

	/**
	 * Calcula a velocidade da bala usando a seguinte fórmula.
	 * 
	 * velocidade = 20 - 3 * potência.
	 * 
	 * @param power potência de disparo da bala
	 * @return velocidade da bala.
	 */
	public double velocidadeDaBala(double power) {

		return 20 - 3 * power;
	}

	/**
	 * Calcula a potência da bala necessária para se percorrer uma determinada
	 * distância em um determinado tempo usando a seguinte fórmula.
	 * 
	 * potência = (distância / tempo - 20) / -3.
	 * 
	 * @param distancia distância que a bala irá percorrer até o seu destino.
	 * @param tempo     duração do percurso da bala até o seu destino.
	 * @return potência da bala.
	 */
	public double poderDaBala(double distancia, double tempo) {

		double x = distancia / tempo;

		return (x - 20) / -3;
	}

	/**
	 * Calcula apenas a velocidade lateral do inimigo em relação ao robo usando a
	 * seguinte fórmula.
	 * 
	 * H = velocidade do inimigo. CO = H * seno(angulo-interno-do-inimigo).
	 * 
	 * Velocidade lateral = CO.
	 * 
	 * @param robo    seu próprio robô
	 * @param inimigo robo adversário
	 * @return velocidade lateral do inimigo em relação ao seu robô.
	 */
	public double velocidadeLateral(CyberPunk robo, ScannedRobotEvent inimigo) {

		double anguloTotal = inimigo.getBearingRadians() + robo.getHeadingRadians();

		velocidadeLateral = inimigo.getVelocity() * Math.sin(inimigo.getHeadingRadians() - anguloTotal);
		return velocidadeLateral;
	}

	public double velocidadeLateralFutura(CyberPunk robo, ScannedRobotEvent inimigo) {

		double headingAtual = 0;
		double posicaoLateral = 0;

		for (int i = 0; i < Padrao.getDadosFuturos().length; i++) {

			if (i == 0) {

				headingAtual = inimigo.getHeading();

			} else {

				headingAtual += Padrao.getDadosFuturos()[i].diferencaHeading;
			}

			double anguloTotal = inimigo.getBearingRadians() + robo.getHeadingRadians();
			posicaoLateral += Padrao.getDadosFuturos()[i].velocity
					* Math.sin(Math.toRadians(headingAtual) - anguloTotal);
		}

		return posicaoLateral;
	}

	public double getVelocidadeHorizontalFutura(CyberPunk robo, ScannedRobotEvent inimigo) {

		double headingAtual = 0;
		double posicaoLateral = 0;

		for (int i = 0; i < Padrao.getDadosFuturos().length; i++) {

			if (i == 0) {

				headingAtual = inimigo.getHeading();

			} else {

				headingAtual += Padrao.getDadosFuturos()[i].diferencaHeading;
			}

			double anguloTotal = inimigo.getBearingRadians() + robo.getHeadingRadians();
			posicaoLateral += Padrao.getDadosFuturos()[i].velocity
					* Math.cos(Math.toRadians(headingAtual) - anguloTotal);
		}

		return posicaoLateral;
	}

	/**
	 * Calcula a posição lateral do inimigo futuramente em um tempo determinado
	 * usando a seguinte fórmula.
	 * 
	 * posição lateral = velocidade lateral * tempo.
	 * 
	 * @param robo    dados do seu próprio robo.
	 * @param inimigo dados do robô adversário.
	 * @param tempo   tempo da posição futura do robô adversário.
	 * @return velocidade lateral do robô inimigo.
	 */
	public double posicaoLateralInimigo(CyberPunk robo, ScannedRobotEvent inimigo, double tempo) {

		return velocidadeLateral(robo, inimigo) * tempo;
	}

	/**
	 * Calcula o ângulo que a arma de girar para chegar a posição do inimigo à
	 * frente em um determinado tempo usando a seguinte fórmula.
	 * 
	 * CO = posição lateral do inimigo. CA = distância do inimigo + distancia do
	 * inimigo a frente.
	 * 
	 * tangente(ângulo) = CO / CA.
	 * 
	 * @param inimigo dados do robô adversário.
	 * @param tempo   quanto tempo o robô inimigo estará a frente.
	 * @param robo    dados do seu próprio robô.
	 * @return ângulo que o robô inimigo estará a frente para uma mira preditiva.
	 */
	public double anguloFrente(ScannedRobotEvent inimigo, double tempo, CyberPunk robo) {

		double angulo = posicaoLateralInimigo(robo, inimigo, tempo)
				/ (inimigo.getDistance() + (inimigo.getVelocity() * tempo * Math.sin(inimigo.getHeadingRadians())));
		return Math.toDegrees(Math.atan(angulo));
	}

	public double anguloFrentePadrao(CyberPunk robo, ScannedRobotEvent inimigo) {

		double angulo = velocidadeLateralFutura(robo, inimigo) / (inimigo.getDistance()
				+ (getVelocidadeHorizontalFutura(robo, inimigo) * Math.sin(inimigo.getHeadingRadians())));
		return Math.toDegrees(Math.atan(angulo));
	}

	/**
	 * Calcula as coordenadas do robô inimigo usando o seu próprio robô como
	 * referência usando as seguintes fórmulas.
	 * 
	 * Â = angulo do robô inimigo em relação ao nosso(bearing) em radianos.
	 * 
	 * iX = H * cosseno(Â) + mX. iY = H * seno(Â) + mY.
	 * 
	 * @param robo    dados do seu próprio robô.
	 * @param inimigo dados do robô inimigo.
	 * @return coordenadas do inimigo.
	 */
	public Coordenada posicaoInimigo(CyberPunk robo, ScannedRobotEvent inimigo) {

		double g = Math.toRadians((robo.getHeading() + inimigo.getBearing()) % 360);
		double iX = robo.getX() + Math.sin(g) * inimigo.getDistance();
		double iY = robo.getY() + Math.cos(g) * inimigo.getDistance();

		return new Coordenada(iX, iY);
	}
}
