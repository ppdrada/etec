using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retIRSeqLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, ret;
            char repete;

            Console.WriteLine("Calcula o valor de Imposto de Renda(IR) a ser retido na fonte");

            do{
                Console.Write("\nInforme o valor do salário para calculo de IR: ");
                sal = double.Parse(Console.ReadLine());

                ret = 0;

                if (sal < 1903.98)
                {
                    ret = 0;
                }

                if (sal > 1903.98 && sal <= 2826.65)
                {
                    ret = sal * 7.5 / 100 - 142.8;
                }

                if (sal > 2826.65 && sal < 3751.05)
                {
                    ret = sal * 15 / 100 - 354.8;
                }

                if (sal > 3751.05 && sal < 4664.68)
                {
                    ret = sal * 22.5 / 100 - 636.13;
                }

                if (sal > 4664.68)
                {
                    ret = sal * 27.5 / 100 - 869.36;
                }

                Console.WriteLine("\nO salário R$ " + sal + " deverá ter R$" + ret + " como retenção na fonte.");
                Console.WriteLine("Deseja executar novamente esse programa? (digite s para sim e n para não)");
                repete = Console.ReadKey().KeyChar;

            }while(repete == 's');

        }
    }
}
