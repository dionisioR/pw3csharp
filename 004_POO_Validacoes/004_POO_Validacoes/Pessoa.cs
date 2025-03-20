using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_POO_Validacoes
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private double peso;
        private double altura;

        public string Nome
        {
            get { return Nome; }
            set
            {
                if (!string.IsNullOrEmpty(nome))
                {
                    nome = value;
                }
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                // value
                if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    throw new ArgumentException("A idade deve ser maior ou igual a 0");
                }
            }
        }

        public double Peso
        {
            get { return peso; }
            set
            {

                if (value > 0)
                {
                    peso = value;
                }
                else
                {
                    throw new ArgumentException("O peso deve ser maior que  0");
                }

            }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public Pessoa(string nome, int idade,double peso, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        public Pessoa() { }


        public string DadosPessoa()
        {
            return $"NOME: {nome} " +
                $"IDADE: {idade} " +
                $"PESO: {peso}" +
                $"ALTURA: {altura}";
        }

        public override string ToString() {
            return $"NOME: {nome} " +
               $"IDADE: {idade} " +
               $"PESO: {peso}" +
               $"ALTURA: {altura}";
        }

    }
}
