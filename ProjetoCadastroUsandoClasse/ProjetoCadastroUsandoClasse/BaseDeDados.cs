using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastroUsandoClasse
{
    internal class BaseDeDados : IBaseDeDados
    {
        public List<Cliente> clientes { get; set; }

        public BaseDeDados()
        {
            clientes = new List<Cliente>();
        }

        public List<Cliente> deleteClientes(string documento)
        {
            var listTemp = clientes.Where(x => x.documento == documento).ToList();
            foreach(Cliente cli in listTemp)
            {
                clientes.Remove(cli);
            }
            return listTemp;
        }

        public List<Cliente> getClientes(string documento)
        {
            var listTemp = clientes.Where(x => x.documento == documento).ToList();
            return listTemp;
        }

        public Cliente insertClientes(Cliente cliente)
        {
            clientes.Add(cliente);
            return cliente;
        }
    }
}
