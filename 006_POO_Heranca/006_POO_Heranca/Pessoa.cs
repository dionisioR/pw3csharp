using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_POO_Heranca
{
    internal class Pessoa
    {
        public string  Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

       public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome completo: ${Nome} ${Sobrenome}");
        }


    }
}
