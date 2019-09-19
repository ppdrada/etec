using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media2NotasLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            char continua;

            Console.WriteLine("Calcula a média de duas notas para vários alunos");

            do{

                Console.Write("\nDigite a primeira nota: ");
                nota1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                nota2 = double.Parse(Console.ReadLine());

                media = (nota1 + nota2) / 2;

                Console.Write("O aluno com notas " + nota1 + " e " + nota2 + " tem média " + media);

                if(media >= 6.0){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" - aprovado");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" - reprovado");
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nDeseja executar este programa novamente?(S/N): ");
                continua = char.Parse(Console.ReadLine());

            }while(continua == 's');
        }
    }
}
