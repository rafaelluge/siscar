using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Clientes
    {
        private string cod_clientes, nome, cpf, data_nasc, endereco,
            bairro, cep, cidade, estado, fone1, fone2, sexo, restricao;

        public string Cod_Cliente 
        {
            get { return cod_clientes; }
            set { cod_clientes = value; }
        }

        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }

        public string CPF 
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Data_Nasc 
        {
            get { return data_nasc; }
            set { data_nasc = value; }
        }

        public string Endereco 
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Bairro 
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string CEP 
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Cidade 
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Estado 
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Fone1 
        {
            get { return fone1; }
            set { fone1 = value; }
        }

        public string Fone2 
        {
            get { return fone2; }
            set { fone2 = value; }
        }

        public string Sexo 
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Resticao 
        {
            get { return restricao; }
            set { restricao = value; }
        }
    }
}
