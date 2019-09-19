using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, mult;
            int[] vetor = new int[10000];
            do
            {
                Console.WriteLine(" ________________________________");
                Console.WriteLine("|                                |");
                Console.WriteLine("|       SISTEMA NÚMEROS          |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|       Menu de opções:          |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|  1. Gera Números Pares         |");
                Console.WriteLine("|  2. Gera Números Impares       |");
                Console.WriteLine("|  3. Gera Números Multiplos     |");
                // Console.WriteLine("|  4. Lista Números Gerados      |");
                Console.WriteLine("|  0. Encerra este Sistema       |");
                Console.WriteLine("|________________________________|\n");
                Console.Write("  Digite a opção desejada: ");
                while (!(int.TryParse(Console.ReadLine(), out opcao)))
                {
                    Console.Write("Opção não numérica. Digite opção desejada: ");
                }

                Console.WriteLine("\n");
                switch (opcao)
                {
                    case 1:
                        GeraPares();
                        break;
                    case 2:
                        GeraImpares();
                        break;
                    case 3:
                        mult = GeraMultiplos();
                        Console.WriteLine("\nRetornou que será multiplo de " + mult);
                        break;
                    //case 4:
                    // ListaNumeros();
                    // break;

                    case 0:
                        Console.WriteLine("Sistema será encerrado");
                        break;
                    default:
                        Console.WriteLine("Opção inexistente!");
                        break;
                }//fim do switch



                Console.Write("\nPressione qualquer tecla para prosseguir");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }

        static void GeraPares()
        {
            int i, qtd;
            int[] pares = new int[1000];
            Console.Clear();
            Console.WriteLine("Sistema Números\n\nGeração de números pares:\n");
            Console.Write("Quanto números pares listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade inválida! Digite quantidade desejada: ");

            i = 1;
            do
            {
                pares[i] = i * 2;
                i++;
            } while (i <= qtd);
            listar(pares, qtd);
        }

        static void GeraImpares()
        {
            int i, qtd, num;
            int[] impares = new int[1000];
            Console.Clear();
            Console.WriteLine("Sistema Números\n\nGeração de números impares:\n");
            Console.Write("Quanto números impares listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade inválida! Digite quantidade desejada: ");

            i = 1;
            while (i <= qtd)
            {
                impares[i] = i * 2 - 1;
                i++;
            }
            //listar(impares, qtd);
        }

        static int GeraMultiplos()
        {
            int aux, i, qtd;
            int[] multi = new int[10000];
            Console.Clear();
            Console.WriteLine("Sistema Números\n\nGeração de números multiplos:\n");
            Console.Write("Multiplo de qual número inteiro? ");
            while (!(int.TryParse(Console.ReadLine(), out aux)))
                Console.Write("Não é um número inteiro! Digite número inteiro do qual deseja gerar multiplos: ");
            Console.Write("Quanto números multiplos listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade inválida! Digite quantidade desejada: ");
            if (qtd > 9999)
            {
                Console.WriteLine("A quantidade máxima é 9.999. Será usado esse valor!");
                qtd = 9999;
            }

            for (i = 1; i <= qtd; i++)
                multi[i] = aux * i;
            //listar(multi, qtd);
            return aux;
        }

        static void listar(int[] rel, int qtd)
        {
            int j;
            Console.WriteLine("\n\nListar:");
            for (j = 1; j <= qtd; j++)
            {
                if (j % 10 != 0)
                    Console.Write(rel[j] + "\t");
                else
                    Console.WriteLine(rel[j]);
            }
        }


        static void Lista()
        {
            Console.Clear();
            Console.WriteLine("Sistema Números\n\nListagem:\n");
        }
    }
}



