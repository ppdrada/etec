using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fórmula_de_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, raiz1, raiz2;
            char repete = 's';

            do{

                Console.WriteLine("Calcula as raizes de uma equação de segundo grau");

                Console.Write("\nDigite o valor de a: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor de b: ");
                b = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor de c: ");
                c = double.Parse(Console.ReadLine());

                delta = (b * b) - 4 * a * c;
                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("Delta = " + b + "² - 4 * " + a + " * " + c);
                Console.WriteLine("Delta = " + (b*b) + " - 4 * " + a + " * " + c);
                Console.WriteLine("Delta = " + (b * b) + " - " + (4 * a) + " * " + c);
                Console.WriteLine("Delta = " + (b * b) + " - " + (4 * a)*c);
                Console.WriteLine("Delta: " + delta);
                Console.WriteLine("-----------------------------------------");

                if (delta > 0)
                {

                    raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("\nA equação " + a + "x²" + " + " + b + "x" + " + " + c + " = 0 tem como raizes " + raiz1 + " e " + raiz2);

                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDelta negativo, equação sem raizes");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.Write("\nDeseja executar esse programa novamente(S/N): ");
                repete = char.Parse(Console.ReadLine());

                while (repete != 's' && repete != 'n')
                {
                    Console.Write("Caractere não esperado: ");
                    repete = char.Parse(Console.ReadLine());
                }

                Console.Clear();


            }while(repete == 's');
        }
    }
}
