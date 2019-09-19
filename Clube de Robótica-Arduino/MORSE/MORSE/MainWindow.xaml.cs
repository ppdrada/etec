using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

using System.IO.Ports;

namespace morse
{

	public partial class MainWindow : Window
	{
		SerialPort port;
		String message;
		String morseMessage;

		public MainWindow()
		{
			InitializeComponent();

			port = new SerialPort("COM7", 2400);

		}

		private void texto_TextChanged(object sender, TextChangedEventArgs e)
		{
            notificationText.Text = "";
			morseMessage = "";
			message = texto.Text.ToString().ToUpper();

			for (int i = 0; i < message.Length; i++)
			{
				morseMessage += letraCodificada(message.ElementAt(i)) + " ";
			}

			morseTexto.Text = morseMessage;

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{

            try
            {
                port.Open();
                port.Write(morseMessage + "\n");
                port.Close();

                notificationText.Foreground = new SolidColorBrush(Colors.White);
                notificationText.Text = "Texto enviado";

            } catch(Exception ex)
            {
                notificationText.Foreground = new SolidColorBrush(Colors.Red);
                notificationText.Text = "Erro ao conectar com arduino: " + ex.Message;
            }

		}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(morseMessage);
            notificationText.Foreground = new SolidColorBrush(Colors.White);
            notificationText.Text = "Copiado para a área de transferência";
        }

        private String letraCodificada(char letra)
        {

            switch (letra)
            {

                case 'A':
                    return ".-";

                case 'B':
                    return "-...";

                case 'C':
                    return "-.-.";

                case 'D':
                    return "-..";

                case 'E':
                    return ".";

                case 'F':
                    return "..-.";

                case 'G':
                    return "--.";

                case 'H':
                    return "....";

                case 'I':
                    return "..";

                case 'J':
                    return ".---";

                case 'K':
                    return "-.-";

                case 'L':
                    return ".-..";

                case 'M':
                    return "--";

                case 'N':
                    return "-.";

                case 'O':
                    return "---";

                case 'P':
                    return ".--.";

                case 'Q':
                    return "--.-";

                case 'R':
                    return ".-.";

                case 'S':
                    return "...";

                case 'T':
                    return "-";

                case 'U':
                    return "..-";

                case 'V':
                    return "...-";

                case 'W':
                    return ".--";

                case 'X':
                    return "-..-";

                case 'Y':
                    return "-.--";

                case 'Z':
                    return "--..";

                case 'Á':
                    return ".-.-";

                case 'À':
                    return ".--.-";

                case 'É':
                    return "..-..";

                case 'Ç':
                    return "..-..";

                case '0':
                    return "-----";

                case '1':
                    return ".----";

                case '2':
                    return "..---";

                case '3':
                    return "...--";

                case '4':
                    return "....-";

                case '5':
                    return ".....";

                case '6':
                    return "-....";

                case '7':
                    return "--...";

                case '8':
                    return "---..";

                case '9':
                    return "----.";

                default:
                    return "/";

            }
        }
    }
}
