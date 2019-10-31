package CYP;

import robocode.ScannedRobotEvent;

/**
 * 
 * Armazena a velocidade e o heading do robo inimigo e de acordo com os últimos
 * movimentos tenta prever os movimentos futuros do robô inimigo.
 *
 */
public class Padrao {

	private static int padroesReconhecidos = 0;

	private static DadosInimigo[] dadosInimigo = new DadosInimigo[5000]; // vetor de dados que guarda todos os
																			// movimentos anteriores do inimigo.
	private static DadosInimigo[] padraoAtual = new DadosInimigo[20]; // vetor de dados que guarda apenas os últimos
																		// movimentos.
	private static DadosInimigo[] dadosFuturos = new DadosInimigo[20]; // variável que guarda a soma das 20 velocidades
																		// laterais futuras do inimigo.

	public static DadosInimigo[] getDadosInimigo() {
		return dadosInimigo;  //retorna os dados do inimigo
	}

	public static void setDadosInimigo(DadosInimigo[] dadosInimigo) {
		Padrao.dadosInimigo = dadosInimigo; //altera os dados do inimigo
	}

	public static DadosInimigo[] getPadraoAtual() {
		return padraoAtual; // retrona o padrão atual
	}

	public static void setPadraoAtual(DadosInimigo[] padraoAtual) {
		Padrao.padraoAtual = padraoAtual; //altera o padrão atual
	}

	public static DadosInimigo[] getDadosFuturos() {
		return dadosFuturos; // retorna os dados futuros
	}

	public static int getPadroesReconhecidos() {
		return padroesReconhecidos; // retorna a quantidade de padrões reconhecidos
	}

	// metodo que adiciona os dados do inimigo no vetor e atualiza o padrão atual
	public static void addDados(double velocity, double heading, double diferencaHeading) {

		for (int i = 0; i < (dadosInimigo.length - 1); i++) { // inicia um loop que vai do inicio até o penúltimo campo do vetor dadosInimigo

			dadosInimigo[i] = dadosInimigo[i + 1]; // os dados da proxima casa são armazenadas nessa
		}

		dadosInimigo[dadosInimigo.length - 1] = new DadosInimigo(velocity, heading, diferencaHeading); // o último campo do vetor guarda o dado mais atual.
		atualizarPadraoAtual(velocity, heading, diferencaHeading); // atualiza o vetor padrão atual da mesma forma.
	}

	// metodo que retorna true se achou padrão ou false se não achou
	public static boolean conferirPadrao(CyberPunk robo, ScannedRobotEvent inimigo) {

		for (int i = 0; i < dadosInimigo.length - 19; i++) { // vai até o fim do vetor - 19 pra não ultrapassar o tamanho do vetor
			
			int count = 0; //conta quantos movimentos coincidem.

			for (int n = 0; n < padraoAtual.length; n++) { // loop que vai de zero até a quantidade de movimentos no padrão atual

				if (padraoAtual[n] != null && dadosInimigo[i + n] != null) { // se padrão atual e dados do inimigo não vazio...

					if (padraoAtual[n].velocity == dadosInimigo[i + n].velocity
							&& padraoAtual[n].diferencaHeading == dadosInimigo[i + n].diferencaHeading) { // se velocidade e diferença de heading iguais...

						count++; //adiciona um no contador de movimentos iguais.

						if (count == 19 && i < dadosInimigo.length - 100) { //se 19 movimentos iguais temos um padrão.

							for (int x = 0; x < 20; x++) { // loop que vai até 20 para pegar os proximos 20 movimentos.

								dadosFuturos[x] = new DadosInimigo(dadosInimigo[i + n + x].velocity,
										dadosInimigo[i + n + x].heading, dadosInimigo[i + n + x].diferencaHeading); // guarda os proximos 20 movimentos nos dados futuros.
							}

							padroesReconhecidos++; // aumenta o contador de padrão reconhecidos
							return true; // retorna sim para padrão reconhecido.
						}
					}
				}
			}
		}

		return false; // se não achou padrões retorna falso.
	}

	// método que atualiza o vetor que contém padrão atual.
	private static void atualizarPadraoAtual(double velocity, double heading, double diferencaHeading) {

		for (int i = 0; i < padraoAtual.length - 1; i++) { // for que vai da primeira até a penúltima casa do vetor

			padraoAtual[i] = padraoAtual[i + 1]; // o item atual recebe o da frente para manter os últimos 20 dados
		}

		padraoAtual[padraoAtual.length - 1] = new DadosInimigo(velocity, heading, diferencaHeading); // ultimo item recebe os dados atuais
	}
}
