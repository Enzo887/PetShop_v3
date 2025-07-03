using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente
    {
        public List<BE.Cliente> BuscarCliente(string dni)
        {
            DAL.Cliente unClienteDAL = new DAL.Cliente();
            return unClienteDAL.BuscarCliente(dni);
        }
        public void RegistrarCliente (BE.Cliente cliente)
        {
            DAL.Cliente clienteDAL = new DAL.Cliente();
            clienteDAL.RegistrarCliente(cliente);
        }
    }
}
