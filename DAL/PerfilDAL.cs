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
    public class PerfilDAL
    {
        public void SalvarImagem(Perfil perfil) 
        {
            try
            {
                String salvarI = (String.Format("UPDATE USUARIOS_CONFIG" +
                    "SET VALOR = '{0}', " +
                    "PLANO_DE_FUNDO = '{1}'" +
                    "WHERE LOGIN = '{2}'", perfil.Imagem, 'I', perfil.Login));

                NpgsqlCommand comandoUpdate = new NpgsqlCommand
                (salvarI, ConnectionFactory.connect());
                comandoUpdate.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                throw new Exception("Falha ao salvar o caminho da Imagem!" + ex.Message);
            }

            finally
            {
                ConnectionFactory.connect().Close();
            }
        }

        public void SalvarCor(Perfil perfil) 
        {
            try
            {
                String salvarC = (String.Format("UPDATE USUARIOS_CONFIG " +
                    "SET VALOR = '{0}', " +
                    "PLANO_DE_FUNDO = '{1}'" +
                    "WHERW LOGIN = '{2}'", perfil.Cor, 'C', perfil.Login));

                NpgsqlCommand comandoUpadate = new NpgsqlCommand
                (salvarC, ConnectionFactory.connect());
                comandoUpadate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao atualizar a COR!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.connect().Close();
            }
        }
    } 
}
