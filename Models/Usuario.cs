using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        private string login;
        private string senha;

        public static class Login 
        {
            private static string user = null;

            public static string User
            {
                get { return user; }
                set { user = value; }
            }
        }

        public string Senha 
        {
            get { return senha;}
            set { senha = value;}
        }
    }
}
