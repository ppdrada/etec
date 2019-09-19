using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Speech.Recognition;

using System.IO.Ports;

namespace LigarLedPorVoz
{
	class Program
	{
		static bool sair = false;
		static SerialPort port;
		static void Main(string[] args)
		{
			port = new SerialPort("COM3", 9600);
			SpeechRecognitionEngine sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("pt-br"));

			Choices frases = new Choices();
			frases.Add(new string[] {"liga", "desliga", "sair"});

			GrammarBuilder builder = new GrammarBuilder();
			builder.Append(frases);

			Grammar g = new Grammar(builder);

			sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
			sre.SetInputToDefaultAudioDevice();
			sre.LoadGrammar(g);

			do
			{
				sre.Recognize();

			} while (!sair);
		}

		static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			switch (e.Result.Text)
			{
				case "liga":
					Mudar(1);
					break;
				case "desliga":
					Mudar(0);
					break;
				case "sair":
					sair = true;
					break;
			}
		}

		static void Mudar(int i)
		{
			port.Open();
			port.Write(""+i);
			port.Close();
		}
	}
}
