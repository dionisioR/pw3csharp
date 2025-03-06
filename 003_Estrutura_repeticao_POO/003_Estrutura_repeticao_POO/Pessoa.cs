using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Estrutura_repeticao_POO
{
    internal class Pessoa
    {

        private string nome;
       
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        //--------------------
        public int Idade { get; set; }

        //----------------------

        private double peso;
        public double Peso { get => peso; set => peso = value; }

        //--------------------
        public Pessoa(string nome, int idade, double peso) { 
            this.nome = nome;
            this.peso = peso;
            Idade = idade;
        }

        public string Resposta()
        {
            return $"Nome: {nome} Idade: {Idade} e Peso: {peso}.";
        }

    }
}
