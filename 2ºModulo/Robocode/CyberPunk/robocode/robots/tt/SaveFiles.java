package tt;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintStream;
import java.util.ArrayList;

import robocode.RobocodeFileOutputStream;

public class SaveFiles {

	BufferedReader reader = null; // the name says for him self
	PrintStream writer = null; // also for this

	String pathOfTheFile;

	public String getPathOfTheFile() {
		return pathOfTheFile;
	}

	public void setPathOfTheFile(String pathOfTheFile) {
		this.pathOfTheFile = pathOfTheFile;
	}

	private ArrayList<Integer> dnaWinner = new ArrayList<>(); // i'm trying to make the mathod of reading be a function
																// that

	// return a array, than, will
	// be possible call for the array that are in this object
	// (this array is also in a file, so, i can just make a new
	// file
	// to other arrays if a want
	private ArrayList<Integer> bestDNAs = new ArrayList<Integer>();

	ArrayList<Integer> ondeVaiFicarOsDaDosLidos = new ArrayList<>();

	public SaveFiles(DarwinCode data) throws IOException {
		// the constructor can get the values of my main class, or, in other words, my
		// robot class
		// this is something really useful, because is the main class, the place where
		// i'm allowed to use some methods of robocode, like the "getDataFile" for
		// example, this is a method that i need
		writer = new PrintStream(new RobocodeFileOutputStream(data.getDataFile("count.dat")));
		reader = new BufferedReader(new FileReader(data.getDataFile("count.dat")));
	}

	public void writeFile() {

		ArrayList<Integer> bestDna = getBestDNAs(); // i create a new arraylist of integer just to better visualization
													// and understanding of the code
		try {

			for (Integer integer : bestDna) { // i use foreach to write on the file that i create before

				writer.println(integer.toString()); // how my arraylist is of int numbers, i had to convert they all
			}
		} finally {
			if (writer != null) { // of course, this condition will always be met, so
				writer.close(); // is where that my file is closed, like a connection with a database
			}
		}
	}

	public void readFile() { // i thik that what i'm doing here are wrong, so LEMBRA DE VER COM O FURLAN
		try {
			try {

				for (int i = 1; i < 6; i++) { // so, this loop will stop going to stop in the same value of the loop
												// that make a "dna" on the main class
												// the loop of the method "buildingADna", they both have 200 int numbers
												// (?)

					dnaWinner.add(Integer.parseInt(reader.readLine())); // when this loop happen (for 200 times), the
																		// reader
					// will reading the file that was populated with the
					// dnas,(remember that the dna will have 200 int
					// numbers
					// now, why i create a new arraylist to save the dna? because is with this
					// arraylist that the loop will be done, after trying a lot of times

				}

			} finally {
				if (reader != null) {
					reader.close(); // like before ......
				}
			}
		} catch (IOException e) {

			e.printStackTrace();

		} catch (NumberFormatException e) {

			e.printStackTrace();
		}

	}

	public ArrayList<Integer> getBestDNAs() {
		return bestDNAs;
	}

	public void setBestDNAs(ArrayList<Integer> bestDNAs) {
		this.bestDNAs = bestDNAs;
	}

	public ArrayList<Integer> getTeste() {
		return dnaWinner;
	}

}
