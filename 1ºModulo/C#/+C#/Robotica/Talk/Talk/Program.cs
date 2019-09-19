using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Talk
{
	class Program
	{
		static string falaReconhecida = "";
		static void Main(string[] args)
		{
			Console.WriteLine("Oi");
			Console.WriteLine("Katana");
			Console.WriteLine("\nAperte qualquer tecla para prosseguir...");
			Console.ReadKey();
			Console.Clear();
			{
				using (SpeechSynthesizer synth = new SpeechSynthesizer())
				{
					int opcao;
					string nome;
					char loop;

					Console.WriteLine("            Katana             ");
					Console.WriteLine("_______________________________");
					Console.WriteLine("|                              |");
					Console.WriteLine("|       Bem Vindo carai!!      |");
					Console.WriteLine("|                              |");
					Console.WriteLine("|______________________________|");
					synth.Speak("Bem-vindo, Carai");

					Console.WriteLine("\nVocê está na beta da Katana, por favor, dá uma grana ae ");
					synth.Speak("Você está na beta da Katana, por favor, Dá uma grana ae!");

					Console.WriteLine("");
					synth.Speak("Fala teu nome aí, porra");

					Console.WriteLine("-----------------------");
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.Write(" Usuário: ");
					Console.ForegroundColor = ConsoleColor.White;
					nome = Console.ReadLine();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("-----------------------");

					synth.Speak("Olá" + nome);



					Console.Clear();

					do
					{

						Console.WriteLine("            Katana             ");
						Console.WriteLine("_______________________________");
						Console.WriteLine("|                              |");
						Console.WriteLine("|       Bem Vindo carai!!      |");
						Console.WriteLine("|                              |");
						Console.WriteLine("|______________________________|");
						Console.WriteLine("\nVocê está na beta da Katana, por favor, dá uma grana ae ");
						Console.WriteLine("");

						Console.WriteLine("-----------------------");
						Console.ForegroundColor = ConsoleColor.DarkRed;
						Console.WriteLine(" Usuário: " + nome);
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("-----------------------");

						synth.Speak("Estou vendo aqui que você quer uma lista," + nome);

						Console.WriteLine(" _______________________________________________");
						Console.WriteLine("|                                               |");
						Console.WriteLine("| 1 - Chupa meu pinto então, o seu, vagabundo   |");
						Console.WriteLine("| 2 - IRINEU                                    |");
						Console.WriteLine("| 3 - rap, do, minecraft                        |");
						Console.WriteLine("| 4 - Vagabundooooo                             |");
						Console.WriteLine("| 0 - Sair                                      |");
						Console.WriteLine("|_______________________________________________|");

					
						// Configure the audio output. 

						synth.SetOutputToDefaultAudioDevice();

						// Speak a string synchronously.
						
						synth.Speak("Digita nessa linha aí, Faz favor!");
						Console.Write("\n\nDigita aqui carai: ");
						opcao = int.Parse(Console.ReadLine());

						switch (opcao)
						{
							case 1:
								synth.Speak("Chupa meu pinto então, o seu, vagabundo");
								break;
							case 2:
								synth.Speak("IRINEU");
								break;
							case 3:
								synth.Speak("rap, do, minecraft");
								break;
							case 4:
								synth.Speak("Vagabundooooooooo");
								break;
							case 0:

								break;
						}

						if (opcao != 0)
						{
							Console.Write("Deseja repetir? (S/N): ");
							while (!char.TryParse(Console.ReadLine(), out loop) || (loop != 's') && (loop != 'n'))
							{
								synth.Speak("ANIMAL, eu falei S ou N: ");
								Console.Write("Digita novamente ai carai: ");
							}
						}
						else
						{
							loop = 's';
						}

						Console.Clear();

					} while (loop == 's' && opcao != 0);
					synth.Speak("faloooooooooooooooooooooou" + nome);

					SpeechRecognitionEngine sre = new SpeechRecognitionEngine();

					Choices colors = new Choices();
					colors.Add(new string[] { "azul", "vermelho", "verde", "sair", "vai tomar no cu" });

					GrammarBuilder gb = new GrammarBuilder();
					gb.Append(colors);

					//Create the Grammar instance.
					Grammar g = new Grammar(gb);
					sre.LoadGrammar(g);

					sre.SpeechRecognized += sre_SpeechRecognized;

					do
					{
						sre.Recognize();
						if (falaReconhecida == "vai tomar no cu")
						{
							synth.Speak("Tomar no cu é vitamina como tu e tua prima");
						}

					} while (falaReconhecida != "sair");
				}
			}
		}
		static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			Console.WriteLine("Fala reconhecida: " + e.Result.Text);
			falaReconhecida = e.Result.Text;
		}
	}
}
  
