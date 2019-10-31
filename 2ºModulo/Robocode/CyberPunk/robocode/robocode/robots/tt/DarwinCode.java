package tt;

import java.awt.Color;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Random;

import javax.xml.stream.events.EndElement;

import robocode.AdvancedRobot;
import robocode.BattleEndedEvent;
import robocode.BulletHitEvent;
import robocode.Condition;
import robocode.CustomEvent;
import robocode.HitByBulletEvent;
import robocode.HitRobotEvent;
import robocode.HitWallEvent;
import robocode.RobotDeathEvent;
import robocode.Rules;
import robocode.ScannedRobotEvent;
import robocode.WinEvent;
import robocode.util.Utils;

public class DarwinCode extends AdvancedRobot {

	public ArrayList<Integer> currentDna = new ArrayList<>(); // this is the "cromossomo" that i am evolving, will had a
																// size
	// of
	// at least 300 int numbers

	public ArrayList<Integer> winnerDNA = new ArrayList<Integer>(); // here is a list of lists,
	// the dnas who pass on the
	// fitness test will be
	// brought to here

	Random builderOfADna = new Random();
	int[] results = new int[4];
	MyFitnessAvaliation avaliation;

	// will be used to make the events on robocode works
	private IScannedRobot enemyWasFound;
	private IOnBulletHit successfulShot;
	private IOnHitRobot HittingTheEnemy;
	private IOnDeath imDead;
	private IonHitWall wall;
	private IOnWin myRobotColors;
	private IBizarreMovin mover;
	// private IsearchTheEnemy seekForEnemy;

	boolean podeMovimentar = true;

	int teste = 0;
	int scannedX;
	int scannedY;
	int height, width;
	SaveFiles iSaveTheDNAs;
	private ScannedRobotEvent enemyData;
	private HitWallEvent parede;
	// private CustomEvent myEvent;

	@Override
	public void onCustomEvent(CustomEvent event) {

		if (event.getCondition().getName().equals("parei")) {

			this.setTurnRight(180);
			this.setAhead(1000);
			this.teste = 0;
		}

	}

	public void run() {

		this.addCustomEvent(new CloseToWallEvent(this));
		this.addCustomEvent(new AlwaysHappeningEvent());
		this.addCustomEvent(new ImNotMoving(this));

		this.setBodyColor(Color.BLACK);
		this.setBulletColor(Color.BLACK);
		this.setGunColor(Color.BLACK);
		this.setRadarColor(Color.BLACK);
		this.setScanColor(Color.BLACK);
		
		this.setTurnRadarRight(Double.POSITIVE_INFINITY);

		buildingADna();
		while (true) {
			loop();
		}
	}

	public void loop() {

		for (Integer base : currentDna) { // this.iSaveTheDNAs.getTeste())

			if (enemyData == null) {
				scan();
				return;
			}
			double x;
			double y;

			radar();
			bestAimEVER();

			if (base == 0) {
				if (enemyData == null) {
					scan();
					return;
				}
				chooseTeBase(base);
				tiro();
				setDebugProperty("movimento:", "Base 0");
				this.scannedX = (int) (getX()
						+ enemyData.getDistance() * Math.sin(getHeadingRadians() + enemyData.getBearingRadians()));
				this.scannedY = (int) (getY()
						+ enemyData.getDistance() * Math.cos(getHeadingRadians() + enemyData.getBearingRadians()));

				x = scannedX;
				x -= getX();
				y = scannedY;
				y -= getY();
				double anguloProAlvo = Math.atan2(x, y);
				double anguloDoAlvo = Utils.normalRelativeAngle(anguloProAlvo - getHeadingRadians());
				double distancia = Math.hypot(x, y);

				double virarAngulo = Math.atan(Math.tan(anguloDoAlvo));

				setTurnRight(virarAngulo);

				if (enemyData.getDistance() <= 150) {
					setTurnLeft(-90 - enemyData.getBearing());
				}

				if (anguloDoAlvo == virarAngulo) {
					setAhead(distancia + 80);
				} else {
					setBack(distancia + 10);
				}
			}

			if (base == 1) {

				if (enemyData == null) {
					scan();
					return;
				}
				chooseTeBase(base);
				tiro();
				setDebugProperty("movimento:", "Base 1");
				this.scannedX = (int) (getX()
						+ enemyData.getDistance() * Math.sin(getHeadingRadians() + enemyData.getBearingRadians()));
				this.scannedY = (int) (getY()
						+ enemyData.getDistance() * Math.cos(getHeadingRadians() + enemyData.getBearingRadians()));

				x = scannedX;
				x -= getX();
				y = scannedY;
				y -= getY();
				double anguloProAlvo = Math.atan2(x, y);
				double anguloDoAlvo = Utils.normalRelativeAngle(anguloProAlvo - getHeadingRadians());
				double distancia = Math.hypot(x, y);

				double virarAngulo = Math.atan(Math.tan(anguloDoAlvo));

				setTurnRight(virarAngulo);

				if (enemyData.getDistance() <= 150) {
					setTurnLeft(-90 - enemyData.getBearing());
				}

				if (anguloDoAlvo == virarAngulo) {
					setAhead(distancia + 80);
				} else {
					setBack(distancia + 10);
				}
			}

			if (base == 2) {
				if (enemyData == null) {
					scan();
					return;
				}
				tiro();
				chooseTeBase(base);
				setDebugProperty("ESSAPORRA: ", "BASE2");
				this.scannedX = (int) (getX()
						+ enemyData.getDistance() * Math.sin(getHeadingRadians() + enemyData.getBearingRadians()));
				this.scannedY = (int) (getY()
						+ enemyData.getDistance() * Math.cos(getHeadingRadians() + enemyData.getBearingRadians()));

				x = scannedX;
				x -= getX();
				y = scannedY;
				y -= getY();
				double anguloProAlvo = Math.atan2(x, y);
				double anguloDoAlvo = Utils.normalRelativeAngle(anguloProAlvo - getHeadingRadians());
				double distancia = Math.hypot(x, y);

				double virarAngulo = Math.atan(Math.tan(anguloDoAlvo));

				setTurnRight(virarAngulo);

				if (enemyData.getDistance() <= 150) {
					setTurnLeft(-90 - enemyData.getBearing());
				}

				if (anguloDoAlvo == virarAngulo) {
					setAhead(distancia + enemyData.getDistance());
				} else {
					setBack(distancia + 50);
				}
			}

			if (base == 3) {
				if (enemyData == null) {
					scan();
					return;
				}
				tiro();
				chooseTeBase(base);
				setDebugProperty("movimento: ", "base 3");
				this.scannedX = (int) (getX()
						+ enemyData.getDistance() * Math.sin(getHeadingRadians() + enemyData.getBearingRadians()));
				this.scannedY = (int) (getY()
						+ enemyData.getDistance() * Math.cos(getHeadingRadians() + enemyData.getBearingRadians()));

				x = scannedX;
				x -= getX();
				y = scannedY;
				y -= getY();
				double anguloProAlvo = Math.atan2(x, y);
				double anguloDoAlvo = Utils.normalRelativeAngle(anguloProAlvo - getHeadingRadians());
				double distancia = Math.hypot(x, y);

				double virarAngulo = Math.atan(Math.tan(anguloDoAlvo));

				setTurnRight(virarAngulo);

				if (enemyData.getDistance() <= 150) {
					setTurnLeft(-90 - enemyData.getBearing());
				}

				if (anguloDoAlvo == virarAngulo) {
					setAhead(distancia + enemyData.getDistance());
				} else {
					setBack(distancia + 80);
				}
			}
			if (base == 4) {

				if (enemyData == null) {
					scan();
					return;
				}
				tiro();
				chooseTeBase(base);
				setDebugProperty("base: ", "4");
				this.scannedX = (int) (getX()
						+ enemyData.getDistance() * Math.sin(getHeadingRadians() + enemyData.getBearingRadians()));
				this.scannedY = (int) (getY()
						+ enemyData.getDistance() * Math.cos(getHeadingRadians() + enemyData.getBearingRadians()));

				x = scannedX;
				x -= getX();
				y = scannedY;
				y -= getY();
				double anguloProAlvo = Math.atan2(x, y);
				double anguloDoAlvo = Utils.normalRelativeAngle(anguloProAlvo - getHeadingRadians());
				double distancia = Math.hypot(x, y);

				double virarAngulo = Math.atan(Math.tan(anguloDoAlvo));

				setTurnRight(virarAngulo);

				if (enemyData.getDistance() <= 150) {
					setTurnLeft(-90 - enemyData.getBearing());
				}

				if (anguloDoAlvo == virarAngulo) {
					setAhead(distancia + 120);
				} else {
					setBack(distancia + 120);
				}
			}
			execute();
		}
	}

	public void chooseTeBase(int base) {

		for (int i = 0; i < currentDna.size(); i++) {

			if (currentDna.get(i) != base) {
				currentDna.remove(i);
				winnerDNA.add(i);
			}
		}
	}

	
	
	
	public void radar() {

		double angleToEnemy = getHeadingRadians() + enemyData.getBearingRadians();

		double radarTurn = Utils.normalRelativeAngle(angleToEnemy - getRadarHeadingRadians());

		double extraTurn = Math.min(Math.atan(36.0 / enemyData.getDistance()), Rules.RADAR_TURN_RATE_RADIANS);

		if (radarTurn < 0) {

			radarTurn -= extraTurn;
		} else {
			radarTurn += extraTurn;
		}

		setTurnRadarRightRadians(radarTurn);
	}

	public void bestAimEVER() {

		double gunTurnAmt;

		double absBearing = enemyData.getBearingRadians() + getHeadingRadians();

		double latVel = enemyData.getVelocity() * Math.sin(enemyData.getHeadingRadians() - absBearing);

		if (enemyData.getDistance() > 300) {

			gunTurnAmt = robocode.util.Utils.normalRelativeAngle(absBearing - getGunHeadingRadians() + latVel / 22);
			setTurnGunRightRadians(gunTurnAmt);

		}
		if (enemyData.getDistance() < 300 && enemyData.getDistance() > 100) {

			gunTurnAmt = Utils.normalRelativeAngle(absBearing - getGunHeadingRadians() + latVel / 15);
			setTurnGunRightRadians(gunTurnAmt);

		}
		if (enemyData.getDistance() < 100) {

			gunTurnAmt = Utils.normalRelativeAngle(absBearing - getGunHeadingRadians() + latVel / 15);
			setTurnGunRightRadians(gunTurnAmt);

		}

	}

	public void tiro() {

		if (enemyData == null) {
			doNothing();
			return;
		}

		if (enemyData.getDistance() > 300) {
			setFire(Rules.MIN_BULLET_POWER);
		}
		if (enemyData.getDistance() < 300 && enemyData.getDistance() > 100) {
			setFire(2);
		}
		if (enemyData.getDistance() < 100) {
			setFire(Rules.MAX_BULLET_POWER);
		}
		if (enemyData.getDistance() > 300 && enemyData.getVelocity() > 6) {
			fire(Rules.MIN_BULLET_POWER);
		}
	}

	public void buildingADna() {

		for (int i = 0; i < 2; i++) {

			int j = builderOfADna.nextInt(5);

			currentDna.add(j);
		}
	}

	public void onBattleEnded(BattleEndedEvent event) {

		if (avaliation.hitTheRobot < 5 && avaliation.hitWall < 5 && avaliation.numberOfDeaths < 5
				&& avaliation.shotsThatHitMe < 15) {
			try {
				iSaveTheDNAs = new SaveFiles(this);
				this.iSaveTheDNAs.setPathOfTheFile("count.dat");
				this.iSaveTheDNAs.writeFile();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

	@Override
	public void onScannedRobot(ScannedRobotEvent event) {

		this.enemyData = event;
		this.enemyWasFound.act(event);
		height = (int) getBattleFieldHeight();
		width = (int) getBattleFieldWidth();
		this.mover.movimento(width, scannedX, height, scannedY);

	}

	@Override
	public void onWin(WinEvent event) {
		this.myRobotColors.changeColors(event);
		this.iSaveTheDNAs.setBestDNAs(winnerDNA);
		//mudaCor();

	}

	public void mudaCor() {
		Random aleatorio1 = new Random();
		Random aleatorio2 = new Random();
		Random aleatorio3= new Random();
		Random aleatorio4 = new Random();
		Random aleatorio5 = new Random();
		Random aleatorio6 = new Random();
		Random aleatorio7 = new Random();
		Random aleatorio8 = new Random();
		Random aleatorio9 = new Random();
		Random aleatorio10 = new Random();
		Random aleatorio11 = new Random();
		Random aleatorio12 = new Random();
		Random aleatorio13 = new Random();
		Random aleatorio14 = new Random();
		Random aleatorio15 = new Random();
		int a,b,c,d,e,f,g,h,i,j,k,l,m,n,o;
		a=aleatorio1.nextInt(255);
		b=aleatorio2.nextInt(255);
		c=aleatorio3.nextInt(255);
		d=aleatorio4.nextInt(255);
		e=aleatorio5.nextInt(255);
		f=aleatorio6.nextInt(255);
		g=aleatorio7.nextInt(255);
		h=aleatorio8.nextInt(255);
		i=aleatorio9.nextInt(255);
		j=aleatorio10.nextInt(255);
		k=aleatorio11.nextInt(255);
		l=aleatorio12.nextInt(255);
		m=aleatorio13.nextInt(255);
		n=aleatorio14.nextInt(255);
		o=aleatorio15.nextInt(255);
		this.setBodyColor(new Color(a,b,c));
		this.setGunColor(new Color(d,e,f));
		this.setRadarColor(new Color(g,h,i));
		this.setBulletColor(new Color(j,k,l));
		this.setScanColor(new Color(m,n,o));
	}
	
	@Override
	public void onBulletHit(BulletHitEvent event) {
		this.successfulShot.exactShot(event);
	}

	@Override
	public void onHitRobot(HitRobotEvent event) {
		this.HittingTheEnemy.imCrushingTheEnemy(event);
		results[0] = +1;
	}

	@Override
	public void onRobotDeath(RobotDeathEvent event) {
		this.imDead.robotDie(event);
		results[1] = +1;
	}

	@Override
	public void onHitWall(HitWallEvent event) {
		this.wall.runForTheWall(event);
		results[2] = +1;

		this.teste++;
		this.parede = event;
	}

	@Override
	public void onHitByBullet(HitByBulletEvent event) {

	}

	public ArrayList<Integer> getCurrentDna() {
		return currentDna;
	}

	public void setCurrentDna(ArrayList<Integer> currentDna) {
		this.currentDna = currentDna;
	}

}
