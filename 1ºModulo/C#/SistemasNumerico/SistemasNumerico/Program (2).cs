using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasNumerico
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();

                opcao = Menu();
                Gerenciador(opcao);

            } while (opcao != 0);

            Console.Write("Aperte qualquer tecla para prosseguir...");
            Console.ReadKey();
        }

        static int Menu()
        {
            int escolha = 9;
            bool errado = true;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" _____________________________");
            Console.WriteLine("|                             |");
            Console.WriteLine("|       Sistema Numérico      |");
            Console.WriteLine("|                             |");
            Console.WriteLine("| Menu de opções:             |");
            Console.WriteLine("|                             |");
            Console.WriteLine("| 1. Gera números pares       |");
            Console.WriteLine("| 2. Gera números ímpares     |");
            Console.WriteLine("| 3. Gera números multiplos   |");
            Console.WriteLine("| 4. Lista números gerados    |");
            Console.WriteLine("| 0. Encerra esse sistema     |");
            Console.WriteLine("|_____________________________|");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nDigite o número da opção desejada: ");

            while (errado)
            {
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    if (escolha < 0 || escolha > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Somente as opções apresentadas! Digite novamente: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        errado = false;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Somente valores númerico! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.Write("\n");
            return escolha;
        }

        static void Gerenciador(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    GeradordePares();
                    break;
                case 2:
                    GeradordeImpares();
                    break;
                case 3:
                    GeradordeMultiplos();
                    break;
                case 4:
                    Lista();
                    break;
                case 0:
                    Console.WriteLine("Sistema será encerrado");
                    break;
            }
        }

        static void GeradordePares()
        {
            int[] lista = new int[100000];
            int qtd, num;
            int cont = 0;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("            Gerador de  pares.\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nDigite o número que será iniciada a contagem: ");
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Somente valor númerico maior que 0! Digite novamente: ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (num % 2 != 0)
            {
                num++;
            }
            Console.Write("\nDigite a qualtidade de numeros pares que será gerados: ");
            while (!int.TryParse(Console.ReadLine(), out qtd) || qtd <= 0 || qtd > 10000)
            {
                if (qtd <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Somente valores númerico maior que 0! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (qtd > 10000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Somente valor númerico menor que 10000! Digite novamente:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Somente valores númerico! Digite novamente: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }


            while (cont < qtd)
            {
                Console.Write("{0}\t", num + cont * 2);

                cont++;

            } 


            Console.Write("\nAperte qualquer tecla para prosseguir...");
            Console.ReadKey();

        }

        static void GeradordeImpares()
        {
            int[] lista = new int[100000];
            int qtd, num;
            int cont = 0;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("            Gerador de ímpares.\n");
            Console.ForegroundColor = ConsoleColor.White;
        
            Console.Write("\nDigite o número que será iniciada a contagem: ");

            while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Somente valor maior que 0! Digite novamente: ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (num % 2 != 1)
            {
                num++;
            }
            Console.Write("\nDigite a qualtidade de numeros ímpares que será gerados: ");
            while (!int.TryParse(Console.ReadLine(), out qtd) || qtd <= 0 || qtd > 10000)
            {
                if (qtd <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Somente valores maior que 0! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (qtd > 10000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Somente valor menor que 10000! Digite novamente:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Somente valores númerico! Digite novamente: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            do
            {
                Console.Write("{0}\t", num + cont * 2);

                cont++;

            } while (cont < qtd);

            Console.Write("\nAperte qualquer tecla para prosseguir...");
            Console.ReadKey();
        }

        static void GeradordeMultiplos()
        {
            int[] lista = new int [100000];
            int multiplo, qtd, num;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                Gerador de multiplos");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nDigite o número na qual serão gerados os multiplos: ");
            while (!int.TryParse(Console.ReadLine(), out multiplo) || multiplo <= 0)
            {
                if (multiplo <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Somente valor maior que 0! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Somente valores númerico inteiro! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

            Console.Write("Insira a quantidade de multiplos a serem gerados: ");
            while (!int.TryParse(Console.ReadLine(), out qtd) || qtd <= 0)
            {
                if (qtd <= 0)
                {
                    Console.Write("Insira valor maior que 0! Digite novamente: ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Somente valores númerico! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.Write("Insira o número onde será iniciada a contagem: ");
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                if (num <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Somente valor maior que 0! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Somente valores númerico! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            while (num % multiplo != 0)
            {
                num++;
            }

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("{0}\t", num + (multiplo * i));

            }

            Console.Write("\nAperte qualquer tecla para prosseguir...");
            Console.ReadKey();

        }

        static void Lista()
        {
            Console.Clear();

            Console.WriteLine("Função a ser desenvolvida");
            Console.WriteLine("\nAperte qualquer tecla para prosseguir...");
            Console.ReadKey();
        }

    }
}

 
