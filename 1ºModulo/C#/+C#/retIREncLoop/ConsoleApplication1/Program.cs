using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetIREncLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, ret;
            char repete;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Calcula o valor de retenção de IR na fonte de renda");

            do{

                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("\nInforme o valor do salário para cálculo de IR: ");
                sal = double.Parse(Console.ReadLine());

                if (sal <= 1903.98)
                {
                    ret = 0;
                }
                else
                {
                    if (sal <= 2826.65)
                    {
                        ret = sal * 7.5 / 100 - 142;
                    }
                    else
                    {
                        if (sal <= 3751.05)
                        {
                            ret = sal * 15 / 100 - 354.80;
                        }
                        else
                        {
                            if (sal <= 4664.68)
                            {
                                ret = sal * 22.5 / 100 - 636.13;
                            }
                            else
                            {
                                ret = sal * 27.5 / 100 - 869.36;
                            }
                        }
                    }
                }

                Console.WriteLine("O salário R$ " + sal + " deverá ter R$ " + ret + " como retenção na fonte. ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nDeseja executar novamente esse programa? (digite s para sim ou n para não): ");
                repete = char.Parse(Console.ReadLine()); //ou repete = Console.ReadKey().KeyChar;
                Console.ForegroundColor = ConsoleColor.White;

            } while (repete == 's');
        }
    }
}
