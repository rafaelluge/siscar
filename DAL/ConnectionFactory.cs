using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using Npgsql;

namespace DAL
{
    public static class ConnectionFactory
    {
        public static NpgsqlConnection connect()
        {
            NpgsqlConnection conn = new NpgsqlConnection
            ("Server=localhost; Port=5433; userid=postgres; password=123456; Database=CSHARP;");
            conn.Open();
            return conn;
        }
    }
}
