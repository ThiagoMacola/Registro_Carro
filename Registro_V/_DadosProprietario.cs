using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_V
{
	class _DadosProprietario
	{

		public float Cpf { get; set; }
		public string Nome { get; set; }
		public string Endereço { get; set; }
		public string DataNascimento { get; set; }
		public string Data_Compra { get; set; }


		public override string ToString()
		{
			return ("Cpf:" + Cpf + " \nNOME:" + Nome + "\nEndereço:" + Endereço + "\nData:" + DataNascimento + "\nData Compra: " + Data_Compra);
		}







	}
}
