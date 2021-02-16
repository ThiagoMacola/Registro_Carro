using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_V
{
	class Program
	{
		static void Main(string[] args)
		{
			
			_DadosProprietario p = new _DadosProprietario();
			_DadosVeiculo s = new _DadosVeiculo();
			int escolha = 0;


			Console.WriteLine("-------MENU DE OPERAÇÕES--------");
			do
			{
					Console.WriteLine("1 - Informe os dados do Usuario e do Veiculo");
					Console.WriteLine("2 - Dados do Veiculo e do Proprietario");
					Console.WriteLine("3 - Finalizar Programa");
					Console.Write("Qual quas operações deseja efetuar: ");
				try
				{
					escolha = int.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.WriteLine("Digite um Valor entre 1 e 3");

				}
					
				if (escolha > 0 && escolha < 4)
				{
					switch (escolha)
					{
						case 1:
							InsiraDados(p, s);

							break;
						case 2:
							LeiaDados(p, s);
							break;
					}
				}
				else Console.WriteLine("Escolha um numero de 1 a 3");			
			} while (escolha != 3);
			Console.WriteLine("APERTE QUALQUER TECLA PARA FINALIZAR!!!");
			Console.ReadKey();
		}

		static void InsiraDados(_DadosProprietario p, _DadosVeiculo s)
		{
			Console.WriteLine();
			Console.WriteLine("Dados Usuario:");
			Console.Write("Cpf do Individuo: ");
			p.Cpf = float.Parse(Console.ReadLine());
			Console.Write("Nome do Individuo: ");
			p.Nome = Console.ReadLine();
			Console.Write("Endereço do Individuo: ");
			p.Endereço = Console.ReadLine();
			Console.Write("Data Nascimento do Individuo: ");
			p.DataNascimento = Console.ReadLine();
			Console.Write("Data de Compra do Veiculo: ");
			p.Data_Compra = Console.ReadLine();
			//Veiculo
			Console.WriteLine();
			Console.WriteLine("Dados Veiculo: ");
			Console.Write("Renavan do Veiculo: ");
			s.Renavan = int.Parse(Console.ReadLine());
			Console.Write("Chassis do Veiculo: ");
			s.Chassis = int.Parse(Console.ReadLine());
			Console.Write("Placa do Veiculo: ");
			s.Placa = Console.ReadLine();
			Console.Write("Marca do Veiculo: ");
			s.Marca = Console.ReadLine();
			Console.Write("Modelo do Veiculo: ");
			s.Modelo =Console.ReadLine();
			Console.Write("Cor do Veiculo: ");
			s.Cor = Console.ReadLine();
			Console.Write("Ano do Veiculo: ");
			s.Ano = int.Parse(Console.ReadLine());
			Console.WriteLine();
		}

		static void LeiaDados(_DadosProprietario p, _DadosVeiculo s)
		{
			Console.WriteLine(p.ToString());
			Console.WriteLine(s.ToString());
		}
	}
}
