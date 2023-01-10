using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastroUsandoClasse
{
    internal interface IBaseDeDados
    {
        List<Cliente> getClientes(string documento);
        List<Cliente> deleteClientes(string documento);
        Cliente insertClientes(Cliente cliente);
    }
}
