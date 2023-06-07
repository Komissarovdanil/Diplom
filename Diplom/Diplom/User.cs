using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class User
    {

        public int id { get; set; }

        private string login, pass, email;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public User() { }

        public User(string login, string pass, string email)
        {
            this.Login = login;
            this.Pass = pass;
            this.Email = email;  
        } 
    }
}
