using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class ClienteBLL
    {
        public bool verificarCampos(Cliente cliente) 
        {
            if (cliente.Nome.Trim().Length == 0) 
            {
                throw new Exception("É obrigatorio o preenchimento do campo NOME!");
            }
            if (cliente.CPF.Trim().Length == 0) 
            {
                throw new Exception("É obrigatorio o preencimento do campo CPF!");
            }

            try
            {
                Convert.ToString(Convert.ToDateTime(cliente.Data_Nasc));
            }
            catch 
            {
                throw new Exception("Verifique se o campo Data de nascimento foi preenchido corretamente!");
            }
            return true;

        }

        public void inserirCodigo(Cliente cliente) 
        {
            ClienteDAL clientedal = new ClienteDAL();
            clientedal.InserirCodigo(cliente);
        }

        public void inserirCliente(Cliente cliente)
        {
            ClienteDAL clientedal = new ClienteDAL();
            clientedal.InserirCliente(cliente);
        }

        public void atualizarCliente(Cliente cliente) 
        {
            ClienteDAL clientedal = new ClienteDAL();
            clientedal.AtualizarCliente(cliente);
        }
        public void excluirCliente(Cliente cliente) 
        {
            ClienteDAL clientedal = new ClienteDAL();
            clientedal.ExcluirCliente(cliente);
        }
    }

}
