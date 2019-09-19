using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCenc
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo, repete;
            double kg, imc,peso,alt;

            Console.WriteLine("\n Calcula o Índice de Massa Corporal (IMC)");

            do
            {
                Console.Write("\n Insira seu Sexo (M para Masculino F para Feminino): ");

                while (!char.TryParse(Console.ReadLine().ToUpper(), out sexo) || (sexo != 'M' || sexo != 'F')) //sexo = char.Parse(Console.ReadLine())
                {
                    Console.Write(" Sexo inválido! Digite novamente: ");
                }

                Console.Write(" Insira o peso (Kg): ");
                while (!(double.TryParse(Console.ReadLine(), out kg)))
                {
                    Console.Write(" Peso inválido! Digite novamente: ");
                }

                Console.Write(" Insira a altura (m): ");
                while (!(double.TryParse(Console.ReadLine(), out alt)))
                {
                    Console.Write(" Altura inválida! Digite novamente: ");
                }

                //altu = System.Convert.ToDouble(alt);  //Converter de Decimal para Double

                imc = kg / Math.Pow(alt, 2); // (alt * alt);
                

                Console.WriteLine("\n IMC: {0:N3}", imc);

                if (sexo == 'M')
                {
                    peso = 26.4 * Math.Pow(alt, 2); //Para saber a peso ideal da pessoa.

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n Homem");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (imc < 20.7)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n Com IMC abaixo do ideal");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n O peso ideal seria: {0:N2}", peso);
                    }
                    else
                    {
                        if ((imc >= 20.7) && (imc <= 26.4))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\n Com o IMC ideal ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {

                            if ((imc > 26.4) && (imc <= 31.1))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n Com o IMC acima do peso");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n O peso ideal seria: {0:N2}", peso);
                            }
                            else
                            {
                                if ((imc > 31.1))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n Com o IMC muito acima do peso");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n O peso ideal seria: {0:N2}", peso);
                                }
                            }
                        }
                    }              
                }

                else
                {
                    if(sexo == 'F')
                    {
                        peso = 25.8 * Math.Pow(alt, 2);

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n Mulher");
                        Console.ForegroundColor = ConsoleColor.White;

                        if ((imc < 19.1))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Com IMC abaixo do ideal");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n O peso ideal seria: {0:N2}", peso);
                        }
                        else
                        {
                            if ((imc >= 19.9) && (imc <= 25.8))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("\n Com o IMC ideal ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                if ((imc > 25.8) && (imc <= 32.3))
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\n Com o IMC acima do peso");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n O peso ideal seria: {0:N2}", peso);
                                }    
                                else
                                {
                                    if ((imc > 32.3))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n Com o IMC muito acima do peso");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("\n O peso ideal seria: {0:N2}", peso);
                                    }
                                }
                            }
                        }
                    }
                }

                Console.Write("\n Deseja calcular outro Índice de Nassa Corporal (IMC)? (S/N): ");
                while (!char.TryParse(Console.ReadLine().ToUpper(), out repete)) //ToUpper converte para maiúsculo
                {
                    Console.Write("Somente S para sim  ou N para não. Digite novamente: ");
                }//repete = char.Parse(Console.ReadLine()); ou repete = Console.ReadKey().KeyChar;
                
                Console.Clear();
                
            } while (repete == 'S' );
        }
    }
} 