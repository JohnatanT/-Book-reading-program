using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Nome = "Johnatan";
                p.Idade = 10;
                p.Sexo = 'M';
                p.FazerAniversaio();


                Livro l = new Livro();
                l.Titulo = "C# Orientando a Objeto";
                l.Autor = "School Of Net";
                l.TotPaginas = 300;
                l.Leitor = p;
                l.Folhear(300);

                Console.WriteLine("Página Atual : " + l.PagAtual);

                Console.WriteLine(l.Detalhes());

                Console.WriteLine("Idadedo leitor : " + p.Idade);


                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
