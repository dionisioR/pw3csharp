using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_POO_Validacoes
{
    internal class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        //public Endereco() { }


        //public Endereco(string rua)
        //{

        //}
        //public Endereco(string rua, int numero) { 
        //}

        public Endereco(string rua, int numero,
            string bairro, string cidade, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;

        }

        public void ExibirEndereco()
        {
            Console.WriteLine($"Rua: {Rua}, " +
                $"Número: {Numero}, " +
                $"Bairro: {Bairro}, " +
                $"Cidade: {Cidade}, " +
                $"Estado: {Estado}, " +
                $"CEP: {CEP}");
        }
    }
}
