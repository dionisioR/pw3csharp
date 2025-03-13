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


    }
}
