using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using Microsoft.Speech.Recognition;
using System.IO;

namespace Katana
{
    class Program
    {
		
		static string nome;
        static string recognized;
        static bool firstTime = true;

        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("pt-br"));

            CheckFirstLaunch(synth, sre);
            Welcome(synth);

            Console.Clear();
            Console.WriteLine("Em que posso ajudar?");
            synth.Speak("Em que posso ajudar?");
            do
            {
                UserRequest(synth, sre);

            } while (recognized != "sair");
        }
        static void UserRequest(SpeechSynthesizer synth, SpeechRecognitionEngine sre)
        {

		
            Console.Clear();
            Console.WriteLine("Em que posso ajudar?");

            //Mudar cor do fundo
            Choices bgcolors = new Choices();
            bgcolors.Add(new string[] {"branco", "preto" });

            GrammarBuilder chooseBackground = new GrammarBuilder();
            chooseBackground.Append("Trocar fundo para ");
            chooseBackground.Append(new SemanticResultKey("bgcolor", bgcolors));

            Grammar changeBackground = new Grammar(chooseBackground);

            //Mudar cor da letra
            Choices colors = new Choices();
            colors.Add(new string[] {"branco", "verde", "vermelho", "preto"});

            GrammarBuilder chooseForeground = new GrammarBuilder();
            chooseForeground.Append("Mudar cor da letra para ");
            chooseForeground.Append(new SemanticResultKey("color", colors));


			Grammar changeColor = new Grammar(chooseForeground);

            //Abrir site ou app
            Choices apps = new Choices();
            apps.Add(new string[] {"google", "youtube"});

            GrammarBuilder openApp = new GrammarBuilder();
            openApp.Append("Abrir ");
            openApp.Append(new SemanticResultKey("app", apps));

            Grammar open = new Grammar(openApp);

            if (firstTime)
            {
                sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
                firstTime = false;
            }

            sre.SetInputToDefaultAudioDevice();
            sre.LoadGrammar(changeBackground);
            sre.LoadGrammar(changeColor);
            sre.LoadGrammar(open);
            sre.Recognize();
        }
        static void CheckFirstLaunch(SpeechSynthesizer synth, SpeechRecognitionEngine sre)
        {
            if (!File.Exists("profile.bin"))
            {
                Console.WriteLine("Primeiro me diga o seu nome");
                synth.Speak("Primeiro me diga o seu nome");
                Console.Write("Digite o seu nome: ");
                nome = Console.ReadLine();
                
                FileStream stream = new FileStream("profile.bin", FileMode.Create);
                BinaryWriter writer = new BinaryWriter(stream);

                writer.Write(nome);
                writer.Flush();
                writer.Close();
            }
            else
            {
                FileStream stream = new FileStream("profile.bin", FileMode.Open);
                BinaryReader reader = new BinaryReader(stream);

                nome = reader.ReadString();
            }
        }
        static void Welcome(SpeechSynthesizer synth)
        {
            Console.Clear();
            var date = DateTime.Now;
            Console.WriteLine($"Olá, {nome}");
            Console.WriteLine($"Hoje: {date:d}");
            synth.Speak($"Olá, {nome}");
			synth.Speak($"Hoje é: {date:d}");
        }
        static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            recognized = e.Result.Text;

            if (e.Result.Semantics.ContainsKey("bgcolor"))
            {
                switch (e.Result.Semantics["bgcolor"].Value)
                {
                    case "branco":
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case "preto":
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                }
            }

            if (e.Result.Semantics.ContainsKey("color"))
            {
                switch (e.Result.Semantics["color"].Value)
                {
                    case "branco":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "verde":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "vermelho":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
					case "preto":
						Console.ForegroundColor = ConsoleColor.Black;
						break;
				}
            }

            if (e.Result.Semantics.ContainsKey("app"))
            {
                switch (e.Result.Semantics["app"].Value)
                {
                    case "google":
                        System.Diagnostics.Process.Start("http://google.com");
                        break;
                    case "youtube":
                        System.Diagnostics.Process.Start("http://youtube.com/channel/UCC6ayGbvqQ6R63aoz95ovuA");
                        break;

				}
            }
        }
    }
}
