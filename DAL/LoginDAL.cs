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
    public class LoginDAL
    {
        public bool verificarLogin(Usuario usuario) 
        {
            string validaUsuario = (String.Format(
                "SELECT NOME" +
                "FROM USUARIO" +
                "WHERE LOGIN = '{0}' " +
                "AND SENHA = '{1}'",
                usuario.Login, usuario.Senha));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter
            (new NpgsqlCommand(validaUsuario, ConnectionFactory.connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);
            ConnectionFactory.connect().Dispose();

            if (dt.Rows.Count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
