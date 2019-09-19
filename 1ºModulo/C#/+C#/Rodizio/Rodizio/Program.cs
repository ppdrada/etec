using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            int placa;
            char repete;

            do
            {
                Console.Write("\n Insira o último digito da placa do veículo: ");
                while (!int.TryParse(Console.ReadLine(), out placa))
                {
                    if (placa > 9 || placa < 0)
                    {
                        Console.Write(" Somente numeros entre 0 e 9. Digite novamente: ");
                    }
                    else
                    {
                        Console.Write(" Somente valores numeros. Digite novamente: ");
                    }
                }
                Console.Write("\n");

                switch (placa)
                {
                    case 1:
                    case 2:
                        Console.Write(" Placas com o final 1 e 2.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n É probido circular na Segunda-Feira");
                        Console.ForegroundColor = ConsoleColor.White; 
                        break;
                    case 3:
                    case 4:
                        Console.Write(" Placas com o final 3 e 4.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n É probido circular na Terça-Feira");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 5:
                    case 6:
                        Console.Write(" Placas com o final 5 e 6.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n É probido circular na Quarta-Feira");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 7:
                    case 8:
                        Console.Write(" Placas com o final 7 e 8.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n É probido circular na Quinta-Feira");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 9:
                    case 0:
                        Console.Write(" Placas com o final 9 e 0.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n É probido circular na Sexya-Feira");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }

                Console.Write("\n Deseja executar esse programa novamente? (S/N): ");
                while (!char.TryParse(Console.ReadLine().ToUpper(), out repete) || (repete != 'S' && repete != 'N'))
                {
                    Console.Write(" Somente S para sim e N para não. Digite novamente: ");
                }
                Console.Clear();

            } while (repete == 'S');
             
        }
        
    }
}
