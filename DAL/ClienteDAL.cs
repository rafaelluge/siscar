﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using Npgsql;

namespace DAL
{
    public class ClienteDAL
    {
        public void AtualizarCliente(Cliente cliente) 
        {
            try
            {
                string atualizarC = (string.Format(
                    "UPDATE CLIENTES SET NOME = '{0}'," +
                    "CPF = '{1}," +
                    "DATA_NASC = '{2}'," +
                    "ENDERECO = '{3}'," +
                    "BAIRRO = '{4}'," +
                    "CEP = '{5}," +
                    "CIDADE = '{6}'," +
                    "ESTADO = '{7}'," +
                    "FONE1 = '{8}'," +
                    "FONE2 = '{9}'," +
                    "SEXO = '{10}'," +
                    "RESTRICAO = '{11}'," +
                    "WHERE COD_CLIENTE = '{12}'," +
                    cliente.Nome,
                    cliente.CPF,
                    cliente.Data_Nasc,
                    cliente.Endereco,
                    cliente.Bairro,
                    cliente.CEP,
                    cliente.Cidade,
                    cliente.Estado,
                    cliente.Fone1,
                    cliente.Fone2,
                    cliente.Sexo,
                    cliente.Resticao,
                    cliente.Cod_Cliente));

                NpgsqlCommand comandoUpdate = new NpgsqlCommand
                (atualizarC, ConnectionFactory.connect());
                comandoUpdate.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao atualizar os dados do cliente!" + ex.Message);
            }
            finally 
            {
                ConnectionFactory.connect().Close();
            }
            
            public void InserirCliente(Cliente cliente)
            {
                try
                {
                     string insereC = (string.Format(
                    "INSERT INTO CLIENTES (COD_CLIENTE,"+
                    "NOME," +
                    "CPF," +
                    "DATA_NASC," +
                    "ENDERECO," +
                    "BAIRRO," +
                    "CEP," +
                    "CIDADE," +
                    "ESTADO," +
                    "FONE1," +
                    "FONE2," +
                    "SEXO," +
                    "RESTRICAO)" +
                    "VALUES ('{0}',"+
                    "'{1}',"+
                    "'{2}',"+
                    "'{3}',"+
                    "'{4}',"+
                    "'{5}',"+
                    "'{6}',"+
                    "'{7}',"+
                    "'{8}',"+
                    "'{9}',"+
                    "'{10}',"+
                    "'{11}',"+
                    "'{12}')",
                    cliente.Cod_Cliente,
                    cliente.Nome,
                    cliente.CPF,
                    cliente.Data_Nasc,
                    cliente.Endereco,
                    cliente.Bairro,
                    cliente.CEP,
                    cliente.Cidade,
                    cliente.Estado,
                    cliente.Fone1,
                    cliente.Fone2,
                    cliente.Sexo,
                    cliente.Resticao));

                    NpgsqlCommand comandoInsert= new NpgsqlCommand
                    (insereC, ConnectionFactory.connect())
                    comandoInsert.ExecuteNonQuery();


                }

                catch (Exception ex)
                {
                    throw new Exception("Falha ao inserir cliente!" + ex.Message);
                }
                finally
                {
                    ConnectionFactory.connect().Close();
                }
            }
            public void ExcluirCliente(Cliente cliente)
            {
                try
                {
                    int Codigo = Convert.ToInt32(cliente.Cod_Cliente);

                    string excluiC = (string.Format(
                        "DELETE FROM CLIENTES"+
                        "WHERE COD_CLIENTE = '{0}'",
                        Codigo));
                    NpgsqlCommand comandoDelete = new NpgsqlCommand
                    (excluiC, ConnectionFactory.connect());
                    comandoDelete.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    throw new Exception("Falha ao excluir cliente!"+ ex.Message);
                }
                finally
                {
                    ConnectionFactory.connect().Close();
                }
            }

            public void InserirCodigo(Cliente cliente)
            {
                try
                {
                    string insereCo = (String.Format(
                        "SELECT MAX (COD_CLIENTE)"+
                        "FROM CLIENTE"));

                        NpgsqlDataAdapter da = new NpgsqlDataAdapter
                        (new NpgsqlCommand(insereCo, ConnectionFactory.connect()));
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cliente.Cod_Cliente = dt.Rows[0]["max"].ToString(); 

                    if (cliente.Cod_Cliente== "")
                        cliente.Cod_Cliente ="0";

                    int Codigo = Convert.ToInt32(cliente.Cod_Cliente);
                    Codigo = Codigo +1;
                    cliente.Cod_Cliente = Codigo.ToString();

                }

                catch (Exception ex)
                {
                    throw new Exception ("Falha ao incluir campo na base de dados!" + ex.Message);
                }
                finally
                {
                    ConnectionFactory.connect().Close();
                }
            }


        }
    }
}
