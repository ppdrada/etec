package tt;

import robocode.Condition;

public class ImNotMoving extends Condition {
		
	DarwinCode codigo;
	int teste;
	public ImNotMoving(DarwinCode robo) {

		super("parei");
		
		teste = robo.teste;
		
	}

	@Override
	public boolean test() {

		if(teste > 0) {
			return true;
		}
		
		return false;
	}

}
