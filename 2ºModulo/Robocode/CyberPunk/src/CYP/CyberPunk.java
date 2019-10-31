package CYP;

import java.awt.Color;

import robocode.AdvancedRobot;
import robocode.BulletHitEvent;
import robocode.HitByBulletEvent;
import robocode.HitWallEvent;
import robocode.RoundEndedEvent;
import robocode.ScannedRobotEvent;

public class CyberPunk extends AdvancedRobot {

	ScannedRobotEvent dadosDoInimigo; // Declara uma variavel para guardar os dados do inimigo

	Radar radar; // Declara uma variavel para o objeto radar
	Arma arma; // Declara uma variavel para o objeto arma
	Movimentacao movimentacao; // Declara uma variavel para o objeto movimentacao
	Calculos calculos; // Declara uma variacal para o objeto calculos

	boolean acertou; // Declara uma variavel que armazena se nosso robo acertou o robo inimigo

	public void run() {

		setBodyColor(new Color(0, 0, 0)); // cor do corpo preta
		setGunColor(new Color(0, 150, 50)); // cor da arma preta
		setRadarColor(new Color(0, 100, 100)); // cor do corpo preta
		setBulletColor(new Color(255, 255, 100)); // cor do corpo preta
		setScanColor(new Color(255, 200, 200)); // cor do corpo preta

		setAdjustGunForRobotTurn(true); // Mira independente do corpo
		setAdjustRadarForGunTurn(true); // Radar independente da arma

		radar = new Radar(); // Cria o objeto Radar e joga dentro da variavel radar
		arma = new Arma(); // Cria o objeto Arma e joga dentro da variavel arma
		movimentacao = new Movimentacao(); // Cria o objeto Movimentacao e joga dentro da variavel movimentacao
		calculos = new Calculos(); // Cria o objeto Calculos e joga dentro da variavel calculos

		while (true) { // Loop de execução do robô

			radar.procurar(this); // ele inicia a batalha procurando o cara.
			//setAhead(100); // configura o robo para ir em frente da direção atual.
			movimentacao.mover = true;
			//setTurnRight(150); // configura o robo para virar pra direita
			execute(); // executa todas as configurações anteriores ao mesmo tempo.
		}
	}

	@Override
	public void onScannedRobot(ScannedRobotEvent event) {

		dadosDoInimigo = event; // guarda os dados do inimigo na variavel dados do inimigo.
		radar.seguirInimigo(this, event); // configura o radar para seguir o inimigo.
		movimentacao.movimentos(this, dadosDoInimigo, arma.bala); // chama a classe movimento e passando dados do
																	// inimigo e poder da bala.
		arma.atirar(this, event, 20);// a arma atira quando o cara está a 20 ticks a frente.
		execute(); // executa as configurações dentro das classes.
	}

	@Override
	public void onHitByBullet(HitByBulletEvent event) {

		if (!movimentacao.fugindoX && !movimentacao.fugindoY) { // se não estiver fugindo...
			movimentacao.i *= -1;// quando acertarem uma bala você irá ao contrário da direção atual
		}
	}

	@Override
	public void onHitWall(HitWallEvent event) {

		if (movimentacao.mover) {
			movimentacao.i *= -1;// quando bater na parede você irá ao contrário da direção atual
		}
	}

	@Override
	public void onBulletHit(BulletHitEvent event) {
		acertou = true;// se eu acertei, volta como true para a classe movimentação
	}

	@Override
	public void onRoundEnded(RoundEndedEvent event) {
		
		

//		try {
//			RobocodeFileWriter rfw = new RobocodeFileWriter("./data/enemyData.txt");
//						
//			StringBuilder sb = new StringBuilder();
//			
//			for ( DadosInimigo d : Padrao.getDadosInimigo()) {
//				sb.append(d.heading + "," + d.velocity + "\n");
//			}
//			
//			
//			rfw.write(sb.toString());
//			rfw.close();
//			
//		} catch (IOException e) {
//			e.printStackTrace();
//		}
	}
}