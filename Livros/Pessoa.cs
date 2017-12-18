using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    public class Pessoa
    {
        //Atributos
        private string nome;
        private int idade;
        private char sexo;

        //Encapsulmentos
        public string Nome { get { return nome; } set { nome = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }

        //Metodos
        public void FazerAniversaio()
        {
            this.idade++;
        }

    }
}
