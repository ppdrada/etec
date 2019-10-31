package tt;

import robocode.Condition;

public class CloseToWallEvent extends Condition {

	double myHeadAngle;
	

	double x, y, height, width;
	private DarwinCode robo;

	public CloseToWallEvent(DarwinCode data) {

		super("parede");

		// width 800 px
		width = data.getBattleFieldWidth(); // remember that the getBattleFieldWidth return the value of all the
											// width of the arena
		height = data.getBattleFieldHeight();
		// height 600 px

		x = data.getX();
		y = data.getY();

		this.robo = data;

	}

	private limits regiaoAtual;
	private angles currentAngle;

	public static enum limits { // we create two enums, this will replace all the boolean variables that was
								// used before, that was not work at all
		LEFT_LIMIT, RIGHT_LIMIT, TOP_LIMIT, BOTTOM_LIMIT; // this enum is for the regions of the arena, the explanation
															// for how does it
		// work will be below on the code
	};

	public static enum angles {
		BETWEEN_0_90, BETWEEN_90_180, BETWEEN_180_270, BETWEEN_270_360;

	}

	public limits getRegiaoAtual() { // this two methods going to be used on the event, in the "main" class
		return regiaoAtual;
	}

	public angles getCurrentAngle() {
		return currentAngle;
	}

	@Override
	public boolean test() {

//		if (robo.getHeading() >= 0 && robo.getHeading() <= 90) {
//			this.currentAngle = angles.BETWEEN_0_90;
//		}
//		if (robo.getHeading() > 90 && robo.getHeading() <= 180) {
//			this.currentAngle = angles.BETWEEN_90_180;
//		}
//		if (robo.getHeading() > 180 && robo.getHeading() <= 270) {
//			this.currentAngle = angles.BETWEEN_180_270;
//		}
//		if (robo.getHeading() > 270 && robo.getHeading() <= 360) {
//			this.currentAngle = angles.BETWEEN_270_360;
//		}

		
		
		if(robo.getX() <= robo.getBattleFieldWidth() - 600  || robo.getX() >= robo.getBattleFieldWidth() - 200) {//) {
			return true;
		}
		if(robo.getY() <= robo.getBattleFieldHeight() - 400 || robo.getY() >= robo.getBattleFieldHeight() - 200) {
			return true;
		}
		
//		
//		if (robo.getX() <= 100) {
//			if (robo.getY() >= 500) {
//				this.regiaoAtual = limits.TOP_LIMIT;
//				this.regiaoAtual = limits.LEFT_LIMIT;
//				return true;
//			}
//		}
//		if (robo.getX() <= 100) {
//			if (robo.getY() >= 100) {
//
//				this.regiaoAtual = limits.BOTTOM_LIMIT;
//				this.regiaoAtual = limits.LEFT_LIMIT;
//				return true;
//			}
//		}
//
//		if (robo.getX() >= 700) {
//			if (robo.getY() >= 500) {
//				this.regiaoAtual = limits.RIGHT_LIMIT;
//				this.regiaoAtual = limits.TOP_LIMIT;
//				return true;
//			}
//		}
//		if (robo.getX() >= 700) {
//			if (robo.getY() < 100) {
//				this.regiaoAtual = limits.RIGHT_LIMIT;
//				this.regiaoAtual = limits.BOTTOM_LIMIT;
//				return true;
//			}
//		}
		return false;
	}
}
