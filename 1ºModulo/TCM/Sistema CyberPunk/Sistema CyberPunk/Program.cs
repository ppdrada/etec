using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace TCM___Sistema_Loja
{
	class Program
	{
		static Jogo[] jogos = new Jogo[1000];
		static Plataforma[] plataformas = new Plataforma[1000];
		static Historico[] operacoes = new Historico[1000];
		const int ALL = 0, SOMENTE_VENDA = 1, SOMENTE_COMPRA = 2;

		public struct Jogo
		{
			public string nome;
			public double preco;
            public double precoCompra;
			public string plataforma;
			public string desenvolvedora;
			public int estoque;
		}
		public struct Plataforma
		{
			public string nome;
			public string fabricante;
			public string cor;
			public double preco;
            public double precoCompra;
			public int estoque;
		}
		public struct Historico
		{
			public string operacao;
			public DateTime data;
			public double total;
		}
        public struct CarrinhoJogos
        {
            public int qtd;
        }
        public struct CarrinhoConsoles
        {
            public int qtd;
        }
		static void Main(string[] args)
		{
			int opcao;

			Console.Clear();

			CarregarDados();
			do
			{
				Console.Clear();

				opcao = Menu();
				Gerenciador(opcao);

			} while (opcao != 0);

			Pausa();
		}
		static int Menu()
		{
			int escolha = -1;
			bool errado = true;

            Console.WriteLine("      ____________________________ ");
            Console.WriteLine("     |                            |");
            Console.Write("     |          ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Cyberpunk");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         |");
            Console.WriteLine("     |                            |");
            Console.WriteLine("     |            Menu            |");
            Console.WriteLine("     |                            |");
            Console.Write("     | ");                                     
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Produtos                |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Vendas                  |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("3. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Histórico               |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("4. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sobre                   |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0. ");
            Console.ForegroundColor = ConsoleColor.White;               
            Console.WriteLine("Encerra esse sistema    |");
            Console.WriteLine("     |____________________________|");

			Console.Write("\n Digite o número da opção desejada: ");

			while (errado)
			{
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    if (escolha < 0 || escolha > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" Opção inválida! Digite um número entre as opções: ");
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
                    Console.Write(" Opção não númerica, digite a opção desejada: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
			}
			return escolha;
		}
		static void Gerenciador(int opcao)
		{
			switch (opcao)
			{
				case 0:
					SalvarDados();
					Console.WriteLine("\n O sistema será encerrado");
					Console.WriteLine("\n Salvando dados...");
					break;
				case 1:
					Produtos();
					break;
				case 2:
					Venda();
					break;
				case 3:
					VerHistorico();
					break;
				case 4:
					Desenvolvedores();
					break;
			}
		}
		static void Produtos()
		{
			int escolha = -1;

			do
			{
				Console.Clear();

                Console.WriteLine("      _____________________________");
                Console.WriteLine("     |                             |");
                Console.Write("     |          ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Produtos");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("           |");
                Console.WriteLine("     |                             |");
                Console.Write("     | ");                                     
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Cadastrar produto        |");
                Console.Write("     | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("2. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Editar produto           |");
                Console.Write("     | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("3. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Reposição de estoque     |");
                Console.Write("     | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("0. ");
                Console.ForegroundColor = ConsoleColor.White;          
                Console.WriteLine("Voltar ao menu anterior  |");
                Console.WriteLine("     |_____________________________|");

                Console.Write("\n Digite o número da opção desejada: ");
                while (!int.TryParse(Console.ReadLine(), out escolha) || (escolha < 0) || (escolha > 3))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Opção inválida! Digite um número entre as opções: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

				switch (escolha)
				{
					case 0:
						break;
					case 1:
						CadastrarProduto();
						break;
					case 2:
						EditarProd();
						break;
					case 3:
						ReporEstoque();
						break;
				}

			} while (escolha != 0);
		}

		static void Venda()
		{
			CarrinhoJogos[] carrinhoJogos = new CarrinhoJogos[1000];
            CarrinhoConsoles[] carrinhoConsoles = new CarrinhoConsoles[1000];
			Jogo[] jogosCopia = (Jogo[])jogos.Clone();
			Plataforma[] plataformasCopia = (Plataforma[])plataformas.Clone();

			double total = 0;
			int opcao;

            do
            {

                Console.Clear();

                Console.WriteLine("      _____________________________");
                Console.WriteLine("     |                             |");
                Console.Write("     |          ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Produtos");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("           |");
                Console.WriteLine("     |                             |");
                Console.Write("     | ");                               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Consoles                 |");
                Console.Write("     | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("2. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Jogos                    |");
                Console.Write("     | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("0. ");
                Console.ForegroundColor = ConsoleColor.White;          
                Console.WriteLine("Finalizar compra         |");
                Console.WriteLine("     |_____________________________|");

				MostrarCarrinho(carrinhoJogos, carrinhoConsoles);

                Console.Write("\n Digite o número da opção desejada: ");
                while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < 0) || (opcao > 2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Opção inválida! Digite um número entre as opções: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                switch (opcao)
                {
                    case 1:
                        carrinhoConsoles = VendaConsoles(carrinhoConsoles, plataformasCopia);
                        break;
                    case 2:
						carrinhoJogos = VendaJogos(carrinhoJogos, jogosCopia);
                        break;
                }

            } while (opcao != 0);

            total += CalcularPrecoJogos(carrinhoJogos);
            total += CalcularPrecoConsoles(carrinhoConsoles);

            if(total > 0)
            {
                int index = 0;

                for (int i = 0; i < carrinhoJogos.Length; i++)
                {
                    if (carrinhoJogos[i].qtd != 0)
                    {
                        jogos[i].estoque -= carrinhoJogos[i].qtd;
                    }
                }

                for (int i = 0; i < carrinhoConsoles.Length; i++)
                {
                    if (carrinhoConsoles[i].qtd != 0)
                    {
                        plataformas[i].estoque -= carrinhoConsoles[i].qtd;
                    }
                }

                index = 0;

                while (operacoes[index].operacao != null)
                {
                    index++;
                }

                operacoes[index].operacao = "Venda";
                operacoes[index].data = DateTime.Now;
                operacoes[index].total = total;

                SalvarDados();

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\n Compra finalizada!");
				Console.ForegroundColor = ConsoleColor.White;

				Pausa();
			}
		}
        static CarrinhoJogos[] VendaJogos(CarrinhoJogos[] carrinho, Jogo[] jogosCopia)
        {
            int opcao, mult;

            do
            {
                Console.Clear();

                MostrarJogosFake(SOMENTE_VENDA, jogosCopia);

                Console.WriteLine("\n 0. Voltar para o menu anterior");

                Console.Write("\n Digite a opção desejada: ");
                while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < 0) || (opcao > QuantidadeJogos()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Opção inválida! Digite uma opção válida: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (opcao != 0)
                {
                    Console.Write(" Unidades: ");
					while (!int.TryParse(Console.ReadLine(), out mult) || (mult <= 0))
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" Opção inválida! Apenas números e maiores que zero: ");
						Console.ForegroundColor = ConsoleColor.White;
					} 

					if (mult <= jogos[opcao - 1].estoque && (carrinho[opcao - 1].qtd + mult) <= jogos[opcao - 1].estoque)
                    {
                        carrinho[opcao - 1].qtd += mult;
						jogosCopia[opcao - 1].estoque = jogosCopia[opcao - 1].estoque - mult;
                    }
                    else
                    {
                        if (jogos[opcao - 1].estoque <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Produto indisponível, tente novemente mais tarde");
                            Console.ForegroundColor = ConsoleColor.White;
                            Pausa();
                        }
                        else
                        {
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine(" Quantidade desejada indisponível");
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine(" Unidades disponíveis: {0}", jogos[opcao - 1].estoque);
							Console.ForegroundColor = ConsoleColor.White;
							Pausa();
                        }
                    }
                }

            } while (opcao != 0);

            return carrinho;
        }
        static CarrinhoConsoles[] VendaConsoles(CarrinhoConsoles[] carrinho, Plataforma[] plataformasCopia)
        {
            int opcao, mult;

            do
            {
                Console.Clear();

                MostrarConsolesFake(SOMENTE_VENDA, plataformasCopia);

                Console.WriteLine("\n 0. Voltar para o menu anterior");

                Console.Write("\n Digite a opção desejada: ");
                while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < 0) || (opcao > QuantidadeConsoles()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Opção inválida! Digite uma opção válida: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (opcao != 0)
                {
                    Console.Write(" Unidades: ");
                    while(!int.TryParse(Console.ReadLine(), out mult) || (mult <= 0))
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" Opção inválida! Apenas números e maiores que zero: ");
						Console.ForegroundColor = ConsoleColor.White;
					}

                    if (mult <= plataformas[opcao - 1].estoque && (carrinho[opcao - 1].qtd + mult) <= plataformas[opcao - 1].estoque)
                    {
                        carrinho[opcao - 1].qtd += mult;
						plataformasCopia[opcao - 1].estoque -= mult;
					}
                    else
                    {
                        if (plataformas[opcao - 1].estoque <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Produto indisponível, tente novemente mais tarde");
                            Console.ForegroundColor = ConsoleColor.White;
                            Pausa();
                        }
                        else
                        {
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine(" Quantidade desejada indisponível");
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine(" Unidades disponíveis: {0}", plataformas[opcao - 1].estoque);
							Console.ForegroundColor = ConsoleColor.White;
							Pausa();
                        }
                    }
                }

            } while (opcao != 0);

            return carrinho;
        }
        static double CalcularPrecoJogos(CarrinhoJogos[] carrinho)
        {
            double total = 0;

            for (int i = 0; i < carrinho.Length; i++)
            {
                if(carrinho[i].qtd != 0)
                {
                    total += jogos[i].preco * carrinho[i].qtd;
                }
            }
           
            return total;
        }
        static double CalcularPrecoConsoles(CarrinhoConsoles[] carrinho)
        {
            double total = 0;

            for (int i = 0; i < carrinho.Length; i++)
            {
                if (carrinho[i].qtd != 0)
                {
                    total += plataformas[i].preco * carrinho[i].qtd;
                }
            }

            return total;
        }
		static void VerHistorico()
		{
			DateTime dia;
			double total;
			char confirnova;

			do
			{

				Console.Clear();

				Console.WriteLine("\n Histórico geral:\n");


				for (int i = 0; i < operacoes.Length; i++)
				{
                    if (operacoes[i].operacao != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;                
                        Console.Write(" {0}.", i + 1);
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write(" {0} - {1} -", operacoes[i].operacao, operacoes[i].data);

                        if (operacoes[i].operacao == "Venda")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(" {0:C}.", operacoes[i].total);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" R$ -{0:N2}.", operacoes[i].total);
                            Console.ForegroundColor = ConsoleColor.White;
                        }                                                        
                    }
				}

				Console.Write("\n Deseja consultar uma data? (S/N): ");
				while (!char.TryParse(Console.ReadLine().ToUpper(), out confirnova) || (confirnova != 'S') && (confirnova != 'N'))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Caracter inválido! Digite apenas (S/N): ");
					Console.ForegroundColor = ConsoleColor.White;
				}

				if (confirnova == 'S')
				{
					Console.Write(" Digite a data que deseja consultar: ");
					while (!DateTime.TryParse(Console.ReadLine(), out dia))
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" Data inválida! Digite um formato de data válido: ");
						Console.ForegroundColor = ConsoleColor.White;
					}
					Console.Clear();

					CultureInfo culture = new CultureInfo("pt-br");

					Console.WriteLine("\n Histórico do dia {0:00}/{1:00}/{2} - {3}\n", dia.Day, dia.Month, dia.Year, culture.DateTimeFormat.GetDayName(dia.DayOfWeek));
					total = MostrarHistorico(dia);
					Console.Write("\n --------------------------------------- Total:");

					if (total > 0)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.WriteLine(" {0:C}", total);
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
					{
						if (total < 0)
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine(" {0:C}", total);
							Console.ForegroundColor = ConsoleColor.White;
						}
						else
						{
							Console.WriteLine(" {0:C}", total);
						}
					}
				}

				Pausa();

			} while (confirnova == 'S');
		}

		static void CadastrarConsole()
		{
			string nome = "", fabricante = "", cor = "";
			double preco = 0, precoCompra = 0;
			int estoque;
			char confirm;

			Console.Clear();

			Console.Write(" Digite o nome do console: ");
			while (nome == "")
			{
				nome = Console.ReadLine().ToString();
				if (nome == "")
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}

			Console.Write(" Digite o nome do fabricante: ");
			while (fabricante == "")
			{
				fabricante = Console.ReadLine().ToString();
				if (fabricante == "")
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}

			Console.Write(" Digite o nome da cor do console: ");
			while (cor == "")
			{
				cor = Console.ReadLine().ToString();
				if (cor == "")
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}

			Console.Write(" Digite o preço do console: ");
			while (preco <= 0)
			{
				if (double.TryParse(Console.ReadLine(), out preco))
				{
					if (preco <= 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" Informe um valor maior que zero: ");
						Console.ForegroundColor = ConsoleColor.White;
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Informe apenas números: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}

            Console.Write(" Digite o preço de compra do console: ");
            while (precoCompra <= 0)
            {
                if (double.TryParse(Console.ReadLine(), out precoCompra))
                {
                    if (precoCompra <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" Informe um valor maior que zero: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Informe apenas números: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.Write(" Digite um estoque inicial para o produto: ");
			while (!int.TryParse(Console.ReadLine(), out estoque) || (estoque <=0))
			{
				if (estoque <= 0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Somente números maiores que 0: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
				else
				{
					Console.Write(" Digite apenas números");
				}
			}

			Console.Write(" Deseja cadastrar este produto? (S/N): ");

			while (!char.TryParse(Console.ReadLine().ToUpper(), out confirm) || ((confirm != 'S') && (confirm != 'N')))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(" Apenas S para sim e N para não: ");
				Console.ForegroundColor = ConsoleColor.White;
			}
			if (confirm == 'S')
			{
				int index = 0;

				while (plataformas[index].nome != null)
				{
					index++;
				}

				plataformas[index].nome = nome;
				plataformas[index].fabricante = fabricante;
				plataformas[index].cor = cor;
				plataformas[index].preco = preco;
                plataformas[index].precoCompra = precoCompra;
				plataformas[index].estoque = estoque;

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\n Produto cadastrado!");
				Console.ForegroundColor = ConsoleColor.White;

                SalvarDados();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\n Produto não cadastrado!");
				Console.ForegroundColor = ConsoleColor.White;
			}

			Pausa();
		}
	
		static void CadastrarJogo()
		{
			string nome = "", plataforma = "", desenvolvedora = "";
			double preco = 0, precoCompra = 0;
			int estoque;
			char confirm;

			Console.Clear();

			Console.Write(" Digite o nome do jogo: ");
			while (nome == "")
			{
				nome = Console.ReadLine().ToString();
				if (nome == "")
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}

			Console.Write(" Digite a plataforma do jogo: ");
			while (plataforma == "")
			{
				plataforma = Console.ReadLine().ToString();
				if (plataforma == "")
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}

			Console.Write(" Digite a desenvolvedora do jogo: ");
			while (desenvolvedora == "")
			{
				desenvolvedora = Console.ReadLine().ToString();
				if (desenvolvedora == "")
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}


			Console.Write(" Digite o preço do jogo: ");
			while (preco <= 0)
			{
				if (double.TryParse(Console.ReadLine(), out preco))
				{
					if (preco <= 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" Informe um valor maior que zero: ");
						Console.ForegroundColor = ConsoleColor.White;
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Informe apenas números: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}

            Console.Write(" Digite o preço de compra do jogo: ");
            while (precoCompra <= 0)
            {
                if (double.TryParse(Console.ReadLine(), out precoCompra))
                {
                    if (precoCompra <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" Informe um valor maior que zero: ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Informe apenas números: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.Write(" Digite um estoque inicial para o produto: ");
			while (!int.TryParse(Console.ReadLine(), out estoque) || (estoque <= 0))
			{
				if (estoque <= 0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Somente números maiores que 0: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
				else
				{
					Console.Write(" Digite apenas números");
				}
			}

			Console.Write(" Deseja cadastrar este produto? (S/N): ");

			while (!char.TryParse(Console.ReadLine().ToUpper(), out confirm) || ((confirm != 'S') && (confirm != 'N')))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(" Apenas S para sim e N para não: ");
				Console.ForegroundColor = ConsoleColor.White;
			}
			if (confirm == 'S')
			{
				int index = 0;

				while (jogos[index].nome != null)
				{
					index++;
				}

				jogos[index].nome = nome;
				jogos[index].preco = preco;
                jogos[index].precoCompra = precoCompra;
				jogos[index].plataforma = plataforma;
				jogos[index].desenvolvedora = desenvolvedora;
				jogos[index].estoque = estoque;

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\n Produto cadastrado!");
				Console.ForegroundColor = ConsoleColor.White;
				SalvarDados();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\n Produto não cadastrado!");
				Console.ForegroundColor = ConsoleColor.White;
			}

			Pausa();
		}

		static void CadastrarProduto()
		{
			int escolha = -1;

			Console.Clear();

            Console.WriteLine("      _____________________________");
            Console.WriteLine("     |                             |");
            Console.Write("     |          ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Produtos");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           |");
            Console.WriteLine("     |                             |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cadastrar console        |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cadastrar jogo           |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voltar ao menu anterior  |");
            Console.WriteLine("     |_____________________________|");

            Console.Write("\n Digite o número da opção desejada: ");
            while (!int.TryParse(Console.ReadLine(), out escolha) || (escolha < 0) || (escolha > 3))
			{
				if (escolha < 0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Somente números maiores que 0: ");
					Console.ForegroundColor = ConsoleColor.White;
				}
				else
				{
					Console.Write(" Digite apenas números");
				}
			}

			switch (escolha)
			{
				case 1:
					CadastrarConsole();
					break;
				case 2:
					CadastrarJogo();
					break;
			}

		}
		//edita os atributos de um produto
		static void EditarProd()
		{
			int escolha;

			Console.Clear();

            Console.WriteLine("      _____________________________");
            Console.WriteLine("     |                             |");
            Console.Write("     |          ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Produtos");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           |");
            Console.WriteLine("     |                             |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Editar console           |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Editar jogo              |");
            Console.Write("     | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voltar ao menu anterior  |");
            Console.WriteLine("     |_____________________________|");

            Console.Write("\n Digite o número da opção desejada: ");
            while (!int.TryParse(Console.ReadLine(), out escolha) || (escolha < 0) || (escolha > 2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" Opção inválida! Digite um número entre as opções: ");
                Console.ForegroundColor = ConsoleColor.White;
            }

			switch (escolha)
			{
				case 1:
					EditarConsole();
					break;
				case 2:
					EditarJogo();
					break;
			}
		}
		static void EditarConsole()
		{
			int id, escolha;
			string nome = "", fabricante = "", cor = "";
			double preco = 0, precoCompra = 0;

			Console.Clear();
			MostrarConsoles(ALL);

			Console.WriteLine("\n 0. Voltar ao menu anterior");

			Console.Write("\n\n Digite o id do produto que deseja editar: ");
			while (!int.TryParse(Console.ReadLine(), out id) || (id < 0) || (id > QuantidadeConsoles()))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(" Opção inválida! Apenas números e maiores que zero: ");
				Console.ForegroundColor = ConsoleColor.White;
			}

			if (id != 0)
			{
				Console.WriteLine("\n 1. Nome");
				Console.WriteLine(" 2. Fabricante");
				Console.WriteLine(" 3. Cor");
				Console.WriteLine(" 4. Preço");
				Console.WriteLine(" 5. Preço de compra");
				Console.WriteLine("\n 0. Voltar ao menu anterior");


				Console.Write("\n Digite o número do atributo que deseja editar: ");
				while (!int.TryParse(Console.ReadLine(), out escolha))
				{
					if (escolha < 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" Somente números maiores que 0: ");
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
					{
						Console.Write(" Digite apenas números");
					}
				}

				if (escolha != 0)
				{

					switch (escolha)
					{
						case 1:
							Console.Write(" Digite o novo nome: ");
							while (nome == "")
							{
								nome = Console.ReadLine();
								if (nome == "")
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							plataformas[id - 1].nome = nome;
							break;
						case 2:
							Console.Write(" Digite o novo fabricante: ");
							while (fabricante == "")
							{
								fabricante = Console.ReadLine();
								if (fabricante == "")
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							plataformas[id - 1].fabricante = fabricante;
							break;
						case 3:
							Console.Write(" Digite a nova cor: ");
							while (cor == "")
							{
								cor = Console.ReadLine();
								if (cor == "")
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							plataformas[id - 1].cor = cor;
							break;
						case 4:
							Console.Write(" Digite o novo preço: ");
							while (preco <= 0)
							{
								if (double.TryParse(Console.ReadLine(), out preco))
								{
									if (preco <= 0)
									{
										Console.ForegroundColor = ConsoleColor.Red;
										Console.Write(" Informe um valor maior que zero: ");
										Console.ForegroundColor = ConsoleColor.White;
									}
								}
								else
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Informe apenas números: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							plataformas[id - 1].preco = preco;
							break;
						case 5:
							Console.Write(" Digite o novo preço de compra: ");
							while (precoCompra <= 0)
							{
								if (double.TryParse(Console.ReadLine(), out precoCompra))
								{
									if (precoCompra <= 0)
									{
										Console.ForegroundColor = ConsoleColor.Red;
										Console.Write(" Informe um valor maior que zero: ");
										Console.ForegroundColor = ConsoleColor.White;
									}
								}
								else
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Informe apenas números: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							plataformas[id - 1].precoCompra = precoCompra;
							break;

					}

					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("\n Atributo modificado!");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}

			Pausa();
			SalvarDados();
		}

        static void EditarJogo()
        {
            int id, escolha;
            string nome = "", plataforma = "", desenvolvedora = "";
            double preco = 0, precoCompra = 0;

            Console.Clear();
            MostrarJogos(ALL);

            Console.WriteLine("\n 0. Voltar ao menu anterior");

            Console.Write("\n Digite o id do produto que deseja editar: ");
            while (!int.TryParse(Console.ReadLine(), out id) || (id < 0) || (id > QuantidadeJogos()))
            {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Opção inválida! Digite um número entre as opções: ");
					Console.ForegroundColor = ConsoleColor.White;
			}

			if (id != 0)
			{

				Console.Write("\n 1. ");				
				Console.WriteLine("\n 1. Nome");
				Console.WriteLine(" 2. Preço");
				Console.WriteLine(" 3. Preço de compra");
				Console.WriteLine(" 4. Plataforma");
				Console.WriteLine(" 5. Desenvolvedora");
				Console.WriteLine("\n 0. Voltar ao menu anterior");

				Console.Write("\n Digite o número do atributo deseja modificar: ");

				if (int.TryParse(Console.ReadLine(), out escolha))
				{
					if (escolha <= 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" Informe um valor maior que zero: ");
						Console.ForegroundColor = ConsoleColor.White;
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" Informe apenas números: ");
					Console.ForegroundColor = ConsoleColor.White;
				}

				if (escolha != 0)
				{

					switch (escolha)
					{
						case 1:
							Console.Write(" Digite o novo nome: ");
							while (nome == "")
							{
								nome = Console.ReadLine();
								if (nome == "")
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							jogos[id - 1].nome = nome;
							break;
						case 2:
							Console.Write(" Digite o novo preço: ");
							while (preco <= 0)
							{
								if (double.TryParse(Console.ReadLine(), out preco))
								{
									if (preco <= 0)
									{
										Console.ForegroundColor = ConsoleColor.Red;
										Console.Write(" Informe um valor maior que zero: ");
										Console.ForegroundColor = ConsoleColor.White;
									}
								}
								else
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Informe apenas números: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							jogos[id - 1].preco = preco;
							break;
						case 3:
							Console.Write(" Digite o novo preço de compra: ");
							while (precoCompra <= 0)
							{
								if (double.TryParse(Console.ReadLine(), out precoCompra))
								{
									if (precoCompra <= 0)
									{
										Console.ForegroundColor = ConsoleColor.Red;
										Console.Write(" Informe um valor maior que zero: ");
										Console.ForegroundColor = ConsoleColor.White;
									}
								}
								else
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Informe apenas números: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							jogos[id - 1].precoCompra = precoCompra;
							break;
						case 4:
							Console.Write(" Digite a nova plataforma: ");
							while (plataforma == "")
							{
								plataforma = Console.ReadLine();
								if (plataforma == "")
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							jogos[id - 1].plataforma = plataforma;
							break;
						case 5:
							Console.Write(" Digite a nova desenvolvedora: ");
							while (desenvolvedora == "")
							{
								desenvolvedora = Console.ReadLine();
								if (desenvolvedora == "")
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.Write(" Este campo deve ser preenchido! Digite novamente: ");
									Console.ForegroundColor = ConsoleColor.White;
								}
							}
							jogos[id - 1].desenvolvedora = desenvolvedora;
							break;
					}

					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("\n Atributo modificado!");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
			Pausa();
			SalvarDados();
		}
		//salva os dados das matrizes nos seus respectivos arquivos
		static void SalvarDados()
		{
			int index = 0;

			FileStream stream = new FileStream(@"jogos.bin", FileMode.Create);
			BinaryWriter writer = new BinaryWriter(stream);

			while (jogos[index].nome != null)
			{
				writer.Write(jogos[index].nome);
				writer.Write(jogos[index].preco);
                writer.Write(jogos[index].precoCompra);
				writer.Write(jogos[index].plataforma);
				writer.Write(jogos[index].desenvolvedora);
				writer.Write(jogos[index].estoque);
				index++;
			}
			writer.Flush();
			writer.Close();

			index = 0;

			stream = new FileStream("consoles.bin", FileMode.Create);
			writer = new BinaryWriter(stream);

			while (plataformas[index].nome != null)
			{
				writer.Write(plataformas[index].nome);
				writer.Write(plataformas[index].fabricante);
				writer.Write(plataformas[index].cor);
				writer.Write(plataformas[index].preco);
                writer.Write(plataformas[index].precoCompra);
				writer.Write(plataformas[index].estoque);
                index++;
			}

			writer.Flush();
			writer.Close();

			index = 0;

			stream = new FileStream(@"historico.bin", FileMode.Create);
			writer = new BinaryWriter(stream);

			while (operacoes[index].operacao != null)
			{
				writer.Write(operacoes[index].operacao);
				writer.Write(operacoes[index].data.ToBinary());
				writer.Write(operacoes[index].total);
				index++;
			}
			writer.Flush();
			writer.Close();
		}
		//carrega os dados dos arquivos e guarda em suas respectivas matrizes
		static void CarregarDados()
		{
			FileStream stream;
			if (!File.Exists(@"jogos.bin")) //se o arquivo não existe
			{
				stream = new FileStream(@"jogos.bin", FileMode.Create); //criar arquivo
			}
			else //se o arquivo existe
			{
				stream = new FileStream(@"jogos.bin", FileMode.Open); //abir arquivo
			}

			int index = 0;
			BinaryReader reader = new BinaryReader(stream);
			while (reader.PeekChar() > -1)
			{
				jogos[index].nome = reader.ReadString();
				jogos[index].preco = reader.ReadDouble();
                jogos[index].precoCompra = reader.ReadDouble();
				jogos[index].plataforma = reader.ReadString();
				jogos[index].desenvolvedora = reader.ReadString();
				jogos[index].estoque = reader.ReadInt32();

				index++;
			}
			reader.Close();

			if (!File.Exists("consoles.bin"))
			{
				stream = new FileStream("consoles.bin", FileMode.Create);
			}
			else
			{
				stream = new FileStream("consoles.bin", FileMode.Open);
			}

			index = 0;
			reader = new BinaryReader(stream);
			while (reader.PeekChar() > -1)
			{
				plataformas[index].nome = reader.ReadString();
				plataformas[index].fabricante = reader.ReadString();
				plataformas[index].cor = reader.ReadString();
				plataformas[index].preco = reader.ReadDouble();
                plataformas[index].precoCompra = reader.ReadDouble();
				plataformas[index].estoque = reader.ReadInt32();

				index++;
			}
			reader.Close();

			if (!File.Exists(@"historico.bin")) //se o arquivo não existe
			{
				stream = new FileStream(@"historico.bin", FileMode.Create); //criar arquivo
			}
			else //se o arquivo existe
			{
				stream = new FileStream(@"historico.bin", FileMode.Open); //abrir arquivo
			}

			index = 0;
			reader = new BinaryReader(stream);
			while (reader.PeekChar() > -1)
			{
				operacoes[index].operacao = reader.ReadString();
				operacoes[index].data = DateTime.FromBinary(reader.ReadInt64());
				operacoes[index].total = reader.ReadDouble();

				index++;
			}
			reader.Close();
		}
		//Mostra a lista de todos os jogos salvos.
		static void MostrarJogos(int mostrar)
		{
            Console.WriteLine(" Jogos:\n");

			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(" ID ");
            Console.Write("    Nome\t\t\t    ");
            Console.Write("        Plataforma    ");
            Console.Write("       Desenvolvedora\t   ");
            Console.Write("   Preço\t  ");
			Console.ForegroundColor = ConsoleColor.White;
			if (mostrar == ALL)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Preço de compra\n");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Estoque\n");
				Console.ForegroundColor = ConsoleColor.White;
			}
			
			for (int i = 0; i < QuantidadeJogos(); i++)
			{
				if (jogos[i].nome != null)
				{
					string nome, plataforma, desenvolvedora, index;

					nome = jogos[i].nome;

					while (nome.Length < 35)
					{
						nome += " ";
					}

					if (nome.Length > 35)
					{
						nome = nome.Substring(0, 32);
						nome += "...";
					}

					index = "" + (i + 1);

					while (index.Length < 4)
					{
						index += " ";
					}

					if (index.Length > 4)
					{
						index = index.Substring(0, 4);
					}

					plataforma = jogos[i].plataforma;

					while (plataforma.Length < 20)
					{
						plataforma += " ";
					}

					if (plataforma.Length > 20)
					{
						plataforma = plataforma.Substring(0, 17);
						plataforma += "...";
					}

					desenvolvedora = jogos[i].desenvolvedora;

					while (desenvolvedora.Length < 20)
					{
						desenvolvedora += " ";
					}

					if (desenvolvedora.Length > 20)
					{
						desenvolvedora = desenvolvedora.Substring(0, 17);
						desenvolvedora += "...";
					}

					switch (mostrar)
					{
						case ALL:
							Console.ForegroundColor = ConsoleColor.DarkGreen;  //Alterei até...
							Console.Write(" {0}\t", index);
							Console.ForegroundColor = ConsoleColor.White;
							Console.WriteLine("{0} {1} {2} {3:C}\t  {4:C}",
								nome, plataforma, desenvolvedora, jogos[i].preco, jogos[i].precoCompra);
							break;
						case SOMENTE_VENDA:
							Console.ForegroundColor = ConsoleColor.Green;
							Console.Write(" {0}\t", index);
							Console.ForegroundColor = ConsoleColor.White;
							Console.WriteLine(" {0} {1} {2} {3:C}\t  {4}",
								nome, plataforma, desenvolvedora, jogos[i].preco);
							if (jogos[i].estoque == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("{0}", jogos[i].estoque);
								Console.ForegroundColor = ConsoleColor.White;

							}
							else
							{
								Console.WriteLine("{0}", jogos[i].estoque);
							}
							break;
						case SOMENTE_COMPRA:
							Console.ForegroundColor = ConsoleColor.DarkGreen;
							Console.Write(" {0}\t", index);
							Console.ForegroundColor = ConsoleColor.White;
							Console.Write(" {0} {1} {2} {3:C}\t  {4}",
								nome, plataforma, desenvolvedora, jogos[i].precoCompra);
							if (jogos[i].estoque == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("{0}", jogos[i].estoque);
								Console.ForegroundColor = ConsoleColor.White;

							}
							else
							{
								Console.WriteLine("{0}", jogos[i].estoque);
							}
							break;                                                          //Aqui...
					}
				}
			}
		}
		static void MostrarJogosFake(int mostrar, Jogo[] jogosCopia)
		{

            Console.WriteLine(" Jogos:\n");
			Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ID ");
            Console.Write("    Nome\t\t\t    ");
            Console.Write("        Plataforma    ");
            Console.Write("       Desenvolvedora\t   ");
            Console.Write("   Preço\t  ");
			Console.ForegroundColor = ConsoleColor.White;
			if (mostrar == ALL)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Preço de compra\n");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Estoque\n");
				Console.ForegroundColor = ConsoleColor.White;
			}

			for (int i = 0; i < QuantidadeJogos(); i++)
			{
				if (jogosCopia[i].nome != null)
				{
					string nome, plataforma, desenvolvedora, id;

					nome = jogosCopia[i].nome;

					while (nome.Length < 35)
					{
						nome += " ";
					}

					if (nome.Length > 35)
					{
						nome = nome.Substring(0, 32);
						nome += "...";
					}

					plataforma = jogosCopia[i].plataforma;

					while (plataforma.Length < 20)
					{
						plataforma += " ";
					}

					if (plataforma.Length > 20)
					{
						plataforma = plataforma.Substring(0, 17);
						plataforma += "...";
					}

					desenvolvedora = jogosCopia[i].desenvolvedora;

					while (desenvolvedora.Length < 20)
					{
						desenvolvedora += " ";
					}

					if (desenvolvedora.Length > 20)
					{
						desenvolvedora = desenvolvedora.Substring(0, 17);
						desenvolvedora += "...";
					}

					id = "" + (i + 1);


					while (id.Length < 4)
					{
						id += " ";
					}

					if (id.Length > 4)
					{
						id = id.Substring(0, 4);
					}


					switch (mostrar)
					{

						case ALL:                                                           //Alterei até...
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" {0}\t", id);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" {0} {1} {2} {3:C}\t ",
								nome, plataforma, desenvolvedora, jogosCopia[i].preco, jogosCopia[i].precoCompra);
							break;
						case SOMENTE_VENDA:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" {0}\t", id);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" {0} {1} {2} {3:C}\t ",
								nome, plataforma, desenvolvedora, jogosCopia[i].preco);
							if (jogosCopia[i].estoque == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("   {0}", jogosCopia[i].estoque);
								Console.ForegroundColor = ConsoleColor.White;

							}
							else
							{
								Console.WriteLine("   {0}", jogosCopia[i].estoque);
							}
							break;
						case SOMENTE_COMPRA:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" {0}\t", id);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" {0} {1} {2} {3:C}\t ",
								id, nome, plataforma, desenvolvedora, jogosCopia[i].precoCompra);
							if (jogosCopia[i].estoque == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("   {0}", jogosCopia[i].estoque);
								Console.ForegroundColor = ConsoleColor.White;

							}
							else
							{
								Console.WriteLine("   {0}", jogosCopia[i].estoque);
							}
							break;                                                                //Aqui...
					}
				}
			}
		}
		static void MostrarConsoles(int mostrar)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" Consoles:\n");
            Console.Write(" ID ");
            Console.Write("    Nome\t\t\t    ");
            Console.Write("   Fabricante    ");
            Console.Write("  Cor\t     ");
            Console.Write("    Preço\t\t   ");
			Console.ForegroundColor = ConsoleColor.White;


			if (mostrar == ALL)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Preço de compra\n");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Estoque\n");
				Console.ForegroundColor = ConsoleColor.White;
			}
			for (int i = 0; i < QuantidadeConsoles(); i++)
			{
				if (plataformas[i].nome != null)
				{
					string nome, fabricante, cor, index;

					nome = plataformas[i].nome;

					while (nome.Length < 30)
					{
						nome += " ";
					}

					if (nome.Length > 30)
					{
						nome = nome.Substring(0, 27);
						nome += "...";
					}

					index = "" + (i + 1);
					

					while (index.Length < 4)
					{
						index += " ";
					}

					if (index.Length > 4)
					{
						index = index.Substring(0, 4);						
					}

					fabricante = plataformas[i].fabricante;

					while (fabricante.Length < 15)
					{
						fabricante += " ";
					}

					if (fabricante.Length > 15)
					{
						fabricante = fabricante.Substring(0, 12);
						fabricante += "...";
					}

					cor = plataformas[i].cor;

					while (cor.Length < 17)
					{
						cor += " ";
					}

					if (cor.Length > 17)
					{
						cor = cor.Substring(0, 14);
						cor += "...";
					}

					switch (mostrar)
					{
						case ALL:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;                        //Alterei até...
                            Console.Write(" {0}\t", index);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" {0} {1} {2} {3:C}\t   {4:C}",
								index, nome, fabricante, cor, plataformas[i].preco, plataformas[i].precoCompra);
							break;
						case SOMENTE_VENDA:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" {0}\t", index);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" {0} {1} {2} {3:C}\t  ",
								nome, fabricante, cor, plataformas[i].preco);
							if (plataformas[i].estoque == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("   {0}", plataformas[i].estoque);
								Console.ForegroundColor = ConsoleColor.White;

							}
							else
							{
								Console.WriteLine("   {0}", plataformas[i].estoque);
							}
							break;
						case SOMENTE_COMPRA:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" {0}\t", index);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" {0} {1} {2} {3:C}\t ",
								index, nome, fabricante, cor, plataformas[i].precoCompra);
							if (plataformas[i].estoque == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("   {0}", plataformas[i].estoque);
								Console.ForegroundColor = ConsoleColor.White;

							}
							else
							{
								Console.WriteLine("   {0}", plataformas[i].estoque);
							}
							break;                                                   //Aqui...
					}
				}
			}
		}
		static void MostrarConsolesFake(int mostrar, Plataforma[] plataformasCopia)
		{
			Console.WriteLine(" Consoles:\n");

			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(" ID ");
			Console.Write("    Nome\t\t\t    ");
			Console.Write("   Fabricante    ");
			Console.Write("  Cor\t     ");
			Console.Write("    Preço\t\t   ");
			Console.ForegroundColor = ConsoleColor.White;

			if (mostrar == ALL)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Preço de compra\n");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Estoque                     \n");
				Console.ForegroundColor = ConsoleColor.White;
			}

			for (int i = 0; i < QuantidadeConsoles(); i++)
			{
				if (plataformasCopia[i].nome != null)
				{
					string nome, fabricante, cor, id;

					id = "" + (i + 1);

					while (id.Length < 4)
					{
						id += " ";
					}
					if (id.Length > 4)
					{
						id = id.Substring(0, 4);
					}

					nome = plataformasCopia[i].nome;

					while (nome.Length < 30)
					{
						nome += " ";
					}

					if (nome.Length > 30)
					{
						nome = nome.Substring(0, 27);
						nome += "...";
					}

					fabricante = plataformasCopia[i].fabricante;

					while (fabricante.Length < 15)
					{
						fabricante += " ";
					}

					if (fabricante.Length > 15)
					{
						fabricante = fabricante.Substring(0, 12);
						fabricante += "...";
					}

					cor = plataformasCopia[i].cor;

					while (cor.Length < 17)
					{
						cor += " ";
					}

					if (cor.Length > 17)
					{
						cor = cor.Substring(0, 14);
						cor += "...";
					}

					switch (mostrar)
					{
						case ALL:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;     //Alterei até...
                            Console.Write(" {0}\t", id);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" {0} {1} {2} {3:C}\t   {4:C}",
								id, nome, fabricante, cor, plataformasCopia[i].preco, plataformasCopia[i].precoCompra);
							break;
						case SOMENTE_VENDA:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;   
                            Console.Write(" {0}\t", id);
                            Console.ForegroundColor = ConsoleColor.White;
							Console.Write(" {0} {1} {2} {3:C}\t ",
									nome, fabricante, cor, plataformasCopia[i].precoCompra);
							if (plataformasCopia[i].estoque == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("   {0}", plataformasCopia[i].estoque);
								Console.ForegroundColor = ConsoleColor.White;

							}
							else
							{
								Console.WriteLine("   {0}", plataformasCopia[i].estoque);
							}
							break;                                                              
						case SOMENTE_COMPRA:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;   
                            Console.Write(" {0}\t", id);
                            Console.ForegroundColor = ConsoleColor.White;
							Console.WriteLine(" {0} {1} {2} {3:C}\t ",
								id, nome, fabricante, cor, plataformasCopia[i].precoCompra);
							if (plataformasCopia[i].estoque == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("   {0}", plataformasCopia[i].estoque);
								Console.ForegroundColor = ConsoleColor.White;

							}
							else
							{
								Console.WriteLine("   {0}", plataformasCopia[i].estoque);
							}
							break;                                                           //Aqui
					}
				}
			}
		}
		static void MostrarCarrinho(CarrinhoJogos[] carrinhoJogos, CarrinhoConsoles[] carrinhoConsoles)
		{
            double total = 0;

            if (QuantidadeCarrinho(carrinhoJogos, carrinhoConsoles) > 0)
            {
                Console.WriteLine("\n Carrinho:\n");

				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("  ID");
				Console.Write("    Nome\t\t\t\t");
				Console.Write("    Sub-Total");
				Console.Write("       Qtd");
				Console.WriteLine("   Total\n");
				Console.ForegroundColor = ConsoleColor.White;
			}

			int index = 1;

			for (int i = 0; i < carrinhoConsoles.Length; i++)
			{
				if (carrinhoConsoles[i].qtd != 0)
				{
					string nome, subtotal, id;

					nome = plataformas[i].nome;

					while (nome.Length < 35)
					{
						nome += " ";
					}
					if (nome.Length > 35)
					{
						nome = nome.Substring(0, 32);
						nome += "...";
					}

					subtotal = string.Format("{0:C}", plataformas[i].preco);

					while (subtotal.Length < 14)
					{
						subtotal += " ";
					}
					if(subtotal.Length > 14)
					{
						subtotal = subtotal.Substring(0, 11);
						subtotal += "...";
					}

					id = "" + (i + 1);

					while (id.Length < 4)
					{
						id += " ";
					}
					if (id.Length > 4)
					{
						id = id.Substring(0, 4);
					}


					total += plataformas[i].preco * carrinhoConsoles[i].qtd;
					Console.WriteLine("  {0}\t{1} {2:C}  {3}\t  {4:C}", 
						id, nome, subtotal, carrinhoConsoles[i].qtd,
						(plataformas[i].preco * carrinhoConsoles[i].qtd));
					index++;
				}
			}
			for (int i = 0; i < carrinhoJogos.Length; i++)
			{
				string nome, subtotal, id;

				if (carrinhoJogos[i].qtd != 0)
				{
					nome = jogos[i].nome;

					while (nome.Length < 35)
					{
						nome += " ";
					}
					if (nome.Length > 35)
					{
						nome = nome.Substring(0, 32);
						nome += "...";
					}
					subtotal = string.Format("{0:C}", jogos[i].preco);

					while (subtotal.Length < 14)
					{
						subtotal += " ";
					}
					if (subtotal.Length > 14)
					{
						subtotal = subtotal.Substring(0, 11);
						subtotal += "...";
					}

					id = "" + (i + 1);

					while (id.Length < 4)
					{
						id += " ";
					}
					if (id.Length > 4)
					{
						id = id.Substring(0, 4);
					}


					total += jogos[i].preco * carrinhoJogos[i].qtd;
					Console.WriteLine("  {0}\t{1} {2:C}  {3}\t  {4:C}",
						index, nome, subtotal, carrinhoJogos[i].qtd, (jogos[i].preco * carrinhoJogos[i].qtd));
					index++;
				}
			}

            if (QuantidadeCarrinho(carrinhoJogos, carrinhoConsoles) > 0)
            {
                Console.WriteLine("\n --------------------------------------------------");

				Console.Write("\n Total: ");

				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine("{0:C}", total);
				Console.ForegroundColor = ConsoleColor.White;

			}
		}
        static double MostrarHistorico(DateTime dia)
		{
			double total = 0;

			for (int i = 0; i < operacoes.Length; i++)
			{
				if (operacoes[i].operacao != null && operacoes[i].data.Date == dia.Date)
				{
					if (operacoes[i].operacao == "Venda")
					{
						total += operacoes[i].total;
					}
					else
					{
						total -= operacoes[i].total;
					}

					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write(" {0}.", i + 1);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" {0} - {1} -", operacoes[i].operacao, operacoes[i].data);
					if (operacoes[i].operacao == "Venda")
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.WriteLine(" {0:C}.", operacoes[i].total);
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.DarkRed;
						Console.WriteLine(" R$ -{0:N2}.", operacoes[i].total);
						Console.ForegroundColor = ConsoleColor.White;
					}
				}
			}

			return total;
		}
		static void ReporEstoque()
		{
            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("      _____________________________");
                Console.WriteLine("     |                             |");
                Console.Write("     |          ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Produtos");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("           |");
                Console.WriteLine("     |                             |");
                Console.Write("     | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Repor consoles           |");
                Console.Write("     | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("2. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Repor jogos              |");
                Console.Write("     | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("0. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Voltar ao menu anterior  |");
                Console.WriteLine("     |_____________________________|");

                Console.Write("\n Digite o número da opção desejada: ");
                while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < 0) || (opcao > 2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Opção inválida! Digite um número entre as opções: ");

                    Console.ForegroundColor = ConsoleColor.White;
                }

                switch (opcao)
                {
                    case 1:
                        ReporConsoles();
                        break;
                    case 2:
                        ReporJogos();
                        break;
                }

            } while (opcao != 0);
		}
        static void ReporJogos()
        {
            int id, qtd;
            double total = 0;

            Console.Clear();

            MostrarJogos(SOMENTE_COMPRA);

            Console.WriteLine("\n 0. Voltar ao menu anterior ");
            Console.Write("\n Selecione o ID para repor estoque: ");
            while (!int.TryParse(Console.ReadLine(), out id) || (id < 0) || (id > QuantidadeJogos()))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ID inexistente! Digita um ID válido: ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (id != 0)
            {
                Console.Write(" Digite a quantidade do estoque a ser reposto: ");
                while (!int.TryParse(Console.ReadLine(), out qtd) || (qtd <= 0))
                {
					if (qtd <= 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" Opção inválida! Somente números e maiores que 0: ");
						Console.ForegroundColor = ConsoleColor.White;
					}
                }

                total = jogos[id - 1].precoCompra * qtd;
                jogos[id - 1].estoque += qtd;

                if(total > 0)
                {
                    int index = 0;

                    while (operacoes[index].operacao != null)
                    {
                        index++;
                    }

                    operacoes[index].operacao = "Reposição";
                    operacoes[index].data = DateTime.Now;
                    operacoes[index].total = total;
                }

                SalvarDados();
            }

			Pausa();
        }
        static void ReporConsoles()
        {
            int id, qtd;
            double total = 0;

            Console.Clear();

            MostrarConsoles(SOMENTE_COMPRA);

            Console.WriteLine("\n 0. Voltar ao menu anterior ");
            Console.Write("\n Selecione o ID para repor estoque: ");
            while (!int.TryParse(Console.ReadLine(), out id) || (id < 0) || (id > QuantidadeConsoles()))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ID inexistente! Digita um ID válido: ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (id != 0)
            {
                Console.Write(" Digite a quantidade do estoque a ser reposto: ");
                while (!int.TryParse(Console.ReadLine(), out qtd) || (qtd <= 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Quantidade inválida! Somente números e maiores que 0: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                total += plataformas[id - 1].precoCompra * qtd;
                plataformas[id - 1].estoque += qtd;

                if (total > 0)
                {
                    int index = 0;

                    while (operacoes[index].operacao != null)
                    {
                        index++;
                    }

                    operacoes[index].operacao = "Reposição";
                    operacoes[index].data = DateTime.Now;
                    operacoes[index].total = total;
                }

                SalvarDados();
            }

            Pausa();
        }
		static int QuantidadeJogos()
		{
			int index = 0;

			while (jogos[index].nome != null)
			{
				index++;
			}

			return index;
		}
        static int QuantidadeConsoles()
        {
            int index = 0;

            while (plataformas[index].nome != null)
            {
                index++;
            }

            return index;
        }
        static int QuantidadeCarrinho(CarrinhoJogos[] carrinhoJogos, CarrinhoConsoles[] carrinhoConsoles)
        {
            int count = 0;

            for(int i = 0; i < carrinhoJogos.Length; i++)
            {
                if(carrinhoJogos[i].qtd != 0)
                {
                    count++;
                }
            }

            for (int i = 0; i < carrinhoConsoles.Length; i++)
            {
                if (carrinhoConsoles[i].qtd != 0)
                {
                    count++;
                }
            }

            return count;
        }
		static void Desenvolvedores()
		{

			Console.Clear();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\n ''Nunca chegaremos aonde queremos se não sairemos de onde a gente tamo''"); //Tem q tirar no dia né
			Console.ForegroundColor = ConsoleColor.White;


			Console.WriteLine("                   __________________________");
			Console.WriteLine("                  |                          |");
			Console.Write("                  |         ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("Cyberpunk");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("        |");
			Console.WriteLine("                  |                          |");
			Console.WriteLine("                  |      Desenvolvedores     |");
			Console.WriteLine("                  |                          |");
			Console.WriteLine("                  |      Manoel de Souza     |");
			Console.WriteLine("                  |     Rafael Barros Reis   |");
			Console.WriteLine("                  |        Pedro Lopes       |");
			Console.WriteLine("                  |       Matheus Souza      |");
			Console.WriteLine("                  |       Jorge Augusto      |");
			Console.WriteLine("                  |__________________________|");

			Console.WriteLine("\n                           Versão 7.0");

			Pausa();

		}
		//Dá uma pausa na execução.
		static void Pausa()
		{
			Console.Write("\n Pressione qualquer tecla para continuar...");
			Console.ReadKey();
		}
	}
}