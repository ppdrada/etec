package tt;

public class MyFitnessAvaliation {

	int hitWall, hitTheRobot, numberOfDeaths, shotsThatHitMe;

	public MyFitnessAvaliation(DarwinCode data) {

		hitWall = data.results[0];
		hitTheRobot = data.results[1];
		numberOfDeaths = data.results[2];
		shotsThatHitMe = data.results[3];

	}
	public int hitWall() {
		int howManyTimesIHitTheWall = this.hitWall;
		return howManyTimesIHitTheWall;
	}

	public int hitTheRobot() {
		int howManyTimesIHitTheEnemy = this.hitTheRobot;
		return howManyTimesIHitTheEnemy;
	}

	public int numberOfDeaths() {
		int howManyTimesIDie = this.numberOfDeaths;
		return howManyTimesIDie;
	}

	public int shotsThatHitMe() {
		int howManyShotsHitMe = this.shotsThatHitMe;
		return howManyShotsHitMe;
	}

}
