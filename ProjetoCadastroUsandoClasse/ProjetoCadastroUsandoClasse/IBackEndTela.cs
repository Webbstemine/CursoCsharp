using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastroUsandoClasse
{
    internal interface IBackEndTela
    {
        Cliente Cadastrar();
        List<Cliente> Excluir();
        List<Cliente> Pesquisar();
    }
}
