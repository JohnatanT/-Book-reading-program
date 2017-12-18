using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    public interface IPublicacao
    {
        void Abrir();
        void Fechar();
        void Folhear(int pagina);
        void AvancarPag();
        void VoltarPag();
    }
}
