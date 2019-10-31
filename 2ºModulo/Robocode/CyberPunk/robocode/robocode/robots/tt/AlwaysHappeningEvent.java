package tt;

import robocode.Condition;

public class AlwaysHappeningEvent extends Condition {

	
	public AlwaysHappeningEvent() {
		super("always");
		
		

	}

	@Override
	public boolean test() {

		
		
		return true;
	}

}
