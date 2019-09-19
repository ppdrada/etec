using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCseq
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo = 'x', repete;
            string tryS;
            double altura, peso, pesoIdealM, pesoIdealF, imc;
            bool errado;

            Console.WriteLine("Calcula o IMC de uma pessoa e apresenta a situação da mesma");

            do
            {
                Console.Write("\nDigite o peso em Kg: ");
                while (!double.TryParse(Console.ReadLine(), out peso))
                {
                    Console.Write("Digite corretamente o peso: ");
                }

                Console.Write("Digite a altura em metros: ");
                while (!double.TryParse(Console.ReadLine(), out altura))
                {
                    Console.Write("Digite corretamente a altura: ");
                }

                errado = true;

                while (errado)
                {
                    Console.Write("Informe o seu sexo (M para masculino e F para feminino): ");

                    tryS = Console.ReadLine().ToUpper();

                    if (char.TryParse(tryS, out sexo) && (sexo != 'M' && sexo != 'F'))
                    {
                    Console.WriteLine("Insira um sexo válido");
                    }

                    if (char.TryParse(tryS, out sexo) && (sexo == 'M' || sexo == 'F'))
                    {
                        errado = false;
                    }

                    if (!char.TryParse(tryS, out sexo))
                    {
                        Console.WriteLine("Digite apenas uma letra");
                    }

                }

                imc = peso / Math.Pow(altura, 2);
                pesoIdealM = 22.55 * Math.Pow(altura, 2);
                pesoIdealF = 22.4 * Math.Pow(altura, 2);

                if (sexo == 'M' && imc < 20.7)
                {
                    Console.Write("\nPessoa do sexo masculino com IMC: {0:N2} - ", imc);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Peso abaixo do ideal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Peso Ideal: {0:N2}", pesoIdealM);
                }
                if (sexo == 'M' && (imc >= 20.7 && imc <= 26.4))
                {
                    Console.Write("\nPessoa do sexo masculino com IMC: {0:N2} - ", imc);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Peso ideal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Peso Ideal: {0:N2}", pesoIdealM);
                }
                if (sexo == 'M' && (imc > 26.4 && imc < 31.1))
                {
                    Console.Write("\nPessoa do sexo masculino com IMC: {0:N2} - ", imc);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Acima do ideal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Peso Ideal: {0:N2}", pesoIdealM);
                }
                if (sexo == 'M' && imc >= 31.1)
                {
                    Console.Write("\nPessoa do sexo masculino com IMC: {0:N2} - ", imc);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Muito acima do ideal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Peso Ideal: {0:N2}", pesoIdealM);
                }

                if (sexo == 'F' && imc < 19.1)
                {
                    Console.Write("\nPessoa do sexo feminino com IMC: {0:N2} - ", imc);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Peso abaixo do ideal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Peso Ideal: {0:N2}", pesoIdealF);
                }
                if (sexo == 'F' && (imc >= 19.1 && imc <= 25.7))
                {
                    Console.Write("\nPessoa do sexo feminino com IMC: {0:N2} - ", imc);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Peso ideal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Peso Ideal: {0:N2}", pesoIdealF);
                }
                if (sexo == 'F' && (imc > 25.7 && imc < 32.3))
                {
                    Console.Write("\nPessoa do sexo feminino com IMC: {0:N2} - ", imc);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Acima do ideal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Peso Ideal: {0:N2}", pesoIdealF);
                }
                if (sexo == 'F' && imc >= 32.3)
                {
                    Console.Write("\nPessoa do sexo feminino com IMC: {0:N2} - ", imc);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Muito acima do ideal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Peso Ideal: {0:N2}", pesoIdealF);
                }

                Console.Write("\nDeseja executar o programa novamente? (S/N): ");
                while (!char.TryParse(Console.ReadLine().ToUpper(), out repete) || ((repete != 'S') && (repete != 'N')))
                {
                    Console.Write("Digite s para sim e n para não: ");
                }

            } while (repete == 'S');
        }
    }
}
