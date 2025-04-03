using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_POO_Associacao
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Endereco EnderecoResidencial { get; set; } // Associação com Endreço

        public Pessoa() { }
        public Pessoa(string nome, int idade, Endereco end)
        {
            Nome = nome;
            Idade = idade;
            EnderecoResidencial = end;
            
        }

        public void ExibirDadosPessoa()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}.\n");
            EnderecoResidencial.ExibirEndereco();
        }
    }
}
