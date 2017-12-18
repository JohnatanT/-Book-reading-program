using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    public class Livro : IPublicacao
    {
        //Construtor
        public Livro()
        {
            this.pagAtual = 0;
            this.aberto = false;
        }


        //Atributos
        private string titulo;
        private string autor;
        private int totPaginas;
        private int pagAtual;
        private bool aberto;
        private Pessoa leitor;

        //Encapsulamento
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get { return autor; } set { autor = value; } }
        public int TotPaginas { get { return totPaginas; } set { totPaginas = value; } }
        public int PagAtual { get { return pagAtual; } set { pagAtual = value; } }
        public bool Aberto { get { return aberto; } set { aberto = value; } }
        public Pessoa Leitor { get { return leitor; } set { leitor = value; } }

        //Metodos
        public string Detalhes()
        {
            return "Livro : " + this.titulo + " " + "Autor: " + this.autor + " " + " Total de Páginas: " + this.totPaginas + " "
                + "Leitor: " + this.leitor.Nome;
        }


        public void Abrir()
        {
            if (this.aberto == false)
            {
                this.aberto = true;
            }
            else
            {
                Console.WriteLine("Livro já está aberto.");
            }

        }

        public void AvancarPag()
        {
            if (this.totPaginas >= this.PagAtual)
            {
                this.pagAtual++;
            }
            else
            {
                Console.WriteLine("Impossivel Avançar mais páginas. Livro já acabou!");
            }

        }

        public void Fechar()
        {
            if (this.aberto)
            {
                this.aberto = false;
            }
            else
            {
                Console.WriteLine("Livro já está fechado.");
            }

        }

        public void Folhear(int pagina)
        {
            if (pagina <= this.TotPaginas)
            {
                this.PagAtual = pagina;
            }
            else
            {
                Console.WriteLine("Folheando mais páginas do que o livro possui.");
            }

        }

        public void VoltarPag()
        {
            if (this.pagAtual != 0)
            {
                this.pagAtual--;
            }
            else
            {
                Console.WriteLine("Você está no começo do Livro. Impossivel voltar mais.");
            }

        }

    }
}
