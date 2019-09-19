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
            Console.WriteLine("| 4. Testa primos             |");
            Console.WriteLine("| 5. Gerá numeros primos      |");
            Console.WriteLine("| 6. Lista números gerados    |");
            Console.WriteLine("| 0. Encerra esse sistema     |");
            Console.WriteLine("|_____________________________|");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nDigite o número da opção desejada: ");

            while (errado)
            {
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    if (escolha < 0 || escolha > 6)
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
                    /*listapares =*/ GeradordePares();
                    break;
                case 2:
                    /*listaimpares =*/ GeradordeImpares();
                    break;
                case 3:
                    /*listamultiplos =*/ GeradordeMultiplos();
                    break;
                case 4:
                    TestaPrimos();
                    break;
                case 5:
                    GerarPrimos();
                    break;
                case 6: 
                    Lista();
                    break;
                case 0:
                    Console.WriteLine("Sistema será encerrado");
                    break;
            }
        }

        static int[] GeradordePares()
        {
            int[] lista = new int[1000000];
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
            Console.WriteLine("\nDigite a qualtidade de numeros pares que será gerados: ");
            while (!int.TryParse(Console.ReadLine(), out qtd) || qtd <= 0 || qtd > 1000000)
            {
                if (qtd <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Somente valores númerico maior que 0! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (qtd > 1000000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Somente valor númerico menor que 1000000! Digite novamente:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Somente valores númerico! Digite novamente: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                
            }
            for (int i = 0; i < qtd; i++)
            {
                if (num + cont * 2 != 0)
                {
                    Console.Write("{0}\t", num + cont * 2);
                }
                else
                {
                    Console.Write("{0}\t", num + cont * 2);
                }


                cont++;

            } while (cont < qtd) ;


            Console.Write("\nAperte qualquer tecla para prosseguir...");
            Console.ReadKey();
            return lista;
        }

        static int[] GeradordeImpares()
        {

            int[] lista = new int[1000000];
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
            Console.WriteLine("\nDigite a qualtidade de numeros ímpares que será gerados: ");
            while (!int.TryParse(Console.ReadLine(), out qtd) || qtd <= 0 || qtd > 1000000)
            {
                if (qtd <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Somente valores maior que 0! Digite novamente: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (qtd > 1000000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInsira o número onde será iniciada a contagem: ");
                        Console.Write("Somente valor menor que 1000000! Digite novamente:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Somente valores númerico! Digite novamente: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            for(int i = 0; i < qtd; i++)
            {
               if(num + cont * 2 !=0)
               {
                   Console.Write("{0}\t", num + cont * 2);
               }
               else
               {
                   Console.Write("{0}\t",num  + cont * 2);
               }
                

                cont++;

            } while (cont < qtd);

            Console.Write("\nAperte qualquer tecla para prosseguir...");
            Console.ReadKey();
            return lista;
        }

        static int[] GeradordeMultiplos()
        {
            int[] lista = new int [1000000];
            int multiplo, qtd, num;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("               Gerador de multiplos");
            Console.ForegroundColor = ConsoleColor.White;

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
                    if (num > 1000000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInsira o número onde será iniciada a contagem: ");
                        Console.Write("Somente valor menor que 1000000! Digite novamente:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Somente valores númerico! Digite novamente: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

            }
            Console.Write("Insira o número na qual serão gerados os multiplos: ");
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

                    if (multiplo > 1000000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInsira o número onde será iniciada a contagem: ");
                        Console.Write("Somente valor menor que 1000000! Digite novamente:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Somente valores númerico! Digite novamente: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

            }

            Console.WriteLine("Insira a quantidade de multiplos a serem gerados: ");
            while (!int.TryParse(Console.ReadLine(), out qtd) || qtd <= 0)
            {
                if (qtd <= 0)
                {
                    Console.WriteLine("Somente valor maior que 0! Digite novamente: ");
                }
                else
                {

                    if (qtd > 1000000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInsira o número onde será iniciada a contagem: ");
                        Console.Write("Somente valor menor que 1000000! Digite novamente:");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Somente valores númerico! Digite novamente: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                 }
            }

            

            while (num % multiplo != 0)
            {
                num++;
            }
              for(int i = 0; i < qtd; i++)
            {
                if(num + (multiplo*i) * i !=0)
                {
                    Console.Write("{0}\t", num + (multiplo * i));
                }
                else
                {
                    Console.Write("{0}\t", num + (multiplo * i));
                }


            Console.Write("\nAperte qualquer tecla para prosseguir...");
            Console.ReadKey();
            }
            return lista;
        }
        static void TestaPrimos()
        {
            
        }
        static void GerarPrimos()
        {

        }

        static void Lista()
        {
            Console.Clear();
            /*
            Console.WriteLine("Lista de pares gerados\n" , listapares ,"\n");
            Console.WriteLine("Lista de impares gerados\n", listaimpares , "\n");
            Console.WriteLine("Lista de multiplos gerados\n", listamultiplos , "\n");
            Console.WriteLine("\nAperte qualquer tecla para prosseguir...");
            Console.ReadKey();
            */
        }

    }
}

 
