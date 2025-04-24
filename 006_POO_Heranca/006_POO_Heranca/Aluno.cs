using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_POO_Heranca
{
    internal class Aluno:Pessoa
    {
        public string Curso { get; set; }
        public string Periodo { get; set; }
        public int Ano { get; set; }

        public Endereco End { get; set; }

        public Aluno()
        {
            
        }

        public Aluno(string nome, string sobrenome, string curso, 
            string periodo, int ano,Endereco end)
            :base(nome, sobrenome)
        {
            Curso = curso;
            Periodo = periodo;
            Ano = ano;
            End = end;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Curso: ${Curso} - Perído:${Periodo} " +
                $"Ano: {Ano}.");
            End.ExibirDados();
        }
    }
}
