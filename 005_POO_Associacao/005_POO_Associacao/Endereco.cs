using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_POO_Associacao
{
    internal class Endereco
    {
        public string Rua { get; set; }
        public string  Numero { get; set; }
        public string Cidade{ get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }

        public Endereco() { }
        public Endereco(string rua, string numero, string cidade, 
            string bairro, string uf)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
            UF = uf;
        }

        public void ExibirEndereco()
        {
            Console.WriteLine($"Endereço: {Rua}, {Numero}, {Cidade} - Estado: {UF}");
        }
    }
}
