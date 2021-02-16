using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_V
{
	class _DadosVeiculo
	{

		public int Renavan { get; set; }
		public int Chassis { get; set; }
		public string Placa { get; set; }
		public string Marca { get; set; }
		public int Modelo { get; set; }
		public string Cor { get; set; }
		public int Ano { get; set; }

		public override string ToString()
		{
			return ("Renavan:" + Renavan + " \nChassis:" + Chassis + "\nPlaca:" + Placa + "\nModelo:" + Modelo + "\nCor: " + Cor + "\nAno: " + Ano);
		}








	}
}
