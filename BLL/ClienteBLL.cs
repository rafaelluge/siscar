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
        public bool verificarCampos(Clientes cliente) 
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
    }
}
