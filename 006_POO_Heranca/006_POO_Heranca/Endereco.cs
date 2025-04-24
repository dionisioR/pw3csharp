using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_POO_Heranca
{
    internal class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(){}
        public Endereco(string rua, string numero,
            string bairro, string cidade,string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public void ExibirDados()
        {
   
            Console.WriteLine($"Endereço: {Rua}, Nº: {Numero} " +
                $" Bairro: {Bairro}, {Cidade} - {Estado}");
        }
    }
}
