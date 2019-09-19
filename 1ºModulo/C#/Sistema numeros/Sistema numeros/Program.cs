using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_numeros
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

            Console.WriteLine("\nO sistema será encerrado!");
            Console.Write("Digite qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static int Menu()
        {
            int escolha = -1;
            bool errado = true;

            Console.WriteLine(" ____________________________ ");
            Console.WriteLine("|                            |");
            Console.WriteLine("|       SISTEMA NÚMEROS      |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| Menu de opções:            |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. Gera números pares      |");
            Console.WriteLine("| 2. Gera números ímpares    |");
            Console.WriteLine("| 3. Gera números multiplos  |");
            Console.WriteLine("| 4. Gera números primos     |");
            Console.WriteLine("| 5. Lista números gerados   |");
            Console.WriteLine("| 0. Encerra esse sistema    |");
            Console.WriteLine("|____________________________|");

            Console.Write("\nDigite o número da opção desejada: ");

            while (errado)
            {
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    if (escolha < 0 || escolha > 5)
                    {
                        Console.Write("Digite um número entre as opções disponíveis: ");
                    }
                    else
                    {
                        errado = false;
                    }
                }
                else
                {
                    Console.Write("Opção não númerica, digite a opção desejada: ");
                }
            }

            return escolha;
        }

        static void Gerenciador(int opcao)
        {
            switch (opcao)
            {
                case 0:
                    break;
                case 1:
                    Pares();
                    break;
                case 2:
                    Impares();
                    break;
                case 3:
                    Multiplos();
                    break;
                case 4:
                    Primos();
                    break;
                case 5:
                    Lista();
                    break;
            }
        }

        static void Pares()
        {
            int qtPares, inicio, contador = 0;
            int[] lista = new int[10000];

            Console.Clear();
            Console.WriteLine(" _____________________________________ ");
            Console.WriteLine("|                                     |");
            Console.WriteLine("| 1. Gerador de números pares         |");
            Console.WriteLine("|_____________________________________|");

            Console.Write("\nDigite a qualtidade de pares a serem gerados: ");

            while (!int.TryParse(Console.ReadLine(), out qtPares) || qtPares <= 0 || qtPares > 10000)
            {
                if (qtPares <= 0)
                {
                    Console.Write("Digite um número inteiro maior que zero: ");
                }
                else
                {
                    if (qtPares > 10000)
                    {
                        Console.Write("Informe um número menor que 10000: ");
                    }
                    else
                    {
                        Console.Write("Informe um número inteiro válido: ");
                    }
                }
            }

            Console.Write("Digite o número onde será iniciada a contagem: ");

            while (!int.TryParse(Console.ReadLine(), out inicio) || inicio < 0)
            {
                Console.Write("Digite um número inteiro maior que zero: ");
            }

            Console.WriteLine("---------------------------------------------------------");

            if (inicio % 2 != 0)
            {
                inicio++;
            }

            while (contador < qtPares)
            {
                lista[contador] = inicio + contador * 2;

                contador++;
            }

            for (int i = 0; i < qtPares; i++)
            {
                Console.Write("{0:}\t", lista[i]);
            }

            Console.Write("\n\nDigite qualquer tecla para continuar...");
            Console.ReadKey();

        }

        static void Impares()
        {
            int qtImpares, inicio, contador = 0;

            Console.Clear();
            Console.WriteLine(" _____________________________________ ");
            Console.WriteLine("|                                     |");
            Console.WriteLine("| 2. Gerador de números ímpares       |");
            Console.WriteLine("|_____________________________________|");

            Console.Write("\nDigite a qualtidade de ímpares a serem gerados: ");

            while (!int.TryParse(Console.ReadLine(), out qtImpares) || qtImpares <= 0)
            {
                Console.Write("Digite um número inteiro maior que zero: ");
            }

            Console.Write("Digite o número onde será iniciada a contagem: ");

            while (!int.TryParse(Console.ReadLine(), out inicio) || inicio < 0)
            {
                Console.Write("Digite um número inteiro maior que zero: ");
            }

            Console.WriteLine("\n---------------------------------------------------------");

            if (inicio % 2 != 1)
            {
                inicio++;
            }

            
            do{
                Console.Write("{0}\t", inicio + contador * 2);

                contador++;

            }while(contador < qtImpares);

            Console.Write("\n\nDigite qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void Multiplos()
        {
            int multiplo, qtMultiplos, inicio;

            Console.Clear();

            Console.WriteLine(" _____________________________________ ");
            Console.WriteLine("|                                     |");
            Console.WriteLine("| 3. Gerador de multiplos             |");
            Console.WriteLine("|_____________________________________|");

            Console.Write("\nDigite o número na qual serão gerados os multiplos: ");
            while (!int.TryParse(Console.ReadLine(), out multiplo) || multiplo <= 0)
            {
                if (multiplo <= 0)
                {
                    Console.Write("Digite um número inteiro maior que zero: ");
                }
                else
                {
                    Console.Write("Digite um número inteiro válido");
                }

            }

            Console.Write("Digite a quantidade de multiplos a serem gerados: ");
            while (!int.TryParse(Console.ReadLine(), out qtMultiplos) || qtMultiplos <= 0)
            {
                if (qtMultiplos <= 0)
                {
                    Console.Write("Digite um número inteiro maior que zero: ");
                }
                else
                {
                    Console.Write("Digite um número inteiro válido");
                }
            }

            Console.Write("Digite o número onde será iniciada a contagem: ");
            while (!int.TryParse(Console.ReadLine(), out inicio) || inicio < 0)
            {
                if (inicio <= 0)
                {
                    Console.Write("Digite um número inteiro maior que zero: ");
                }
                else
                {
                    Console.Write("Digite um número inteiro válido");
                }
            }

            while (inicio % multiplo != 0)
            {
                inicio++;
            }

            Console.WriteLine("---------------------------------------------------------");

            for (int i = 0; i < qtMultiplos; i++)
            {
                Console.Write("{0}\t", inicio + (multiplo * i));

            }

            Console.Write("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        }

        static void Primos()
        {
            int qtPrimos, inicio;

            Console.Clear();

            Console.WriteLine(" _____________________________________ ");
            Console.WriteLine("|                                     |");
            Console.WriteLine("| 4. Gerador de primos                |");
            Console.WriteLine("|_____________________________________|");

            Console.Write("\nDigite quantos primos devem ser gerados: ");
            while (!int.TryParse(Console.ReadLine(), out qtPrimos) || qtPrimos <= 0)
            {
                if(qtPrimos <= 0)
                {
                    Console.Write("Digite um número inteiro maior que zero: ");
                }
                else
                {
                    Console.Write("Opção não númerica! Digite novamente:");
                }
            }

            Console.Write("Digite o número onde será iniciada a contagem: ");
            while (!int.TryParse(Console.ReadLine(), out inicio) || inicio < 0)
            {
                if (inicio < 0)
                {
                    Console.Write("Digite um número inteiro maior que zero: ");
                }
                else
                {
                    Console.Write("Opção não númerica! Digite novamente:");
                }
            }

            Console.WriteLine("---------------------------------------------------------");

            for (int i = 0; i < qtPrimos; i++)
            {
                int count = 0;

                while (count != 2)
                {
                    count = 0;

                    for (int k = 1; k <= inicio; k++)
                    {
                        if (inicio % k == 0)
                        {
                            count++;
                        }
                    }

                    if (count == 2)
                    {
                        Console.Write("{0}\t", inicio);
                    }

                    inicio++;
                }
            }

            Console.Write("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        }

        static void Lista()
        {
            Console.Clear();

            Console.WriteLine("Função em desenvolvimento");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }
}
