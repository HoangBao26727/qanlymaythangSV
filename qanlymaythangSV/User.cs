using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qanlymaythangSV
{
    public class User
    {
        private string userName;
        private string password;

        public string UserName { get => userName; set => userName = value; }

        public string Password { get => password; set => password = value; }

        public User(string userName, string password)
        {
           this.userName = userName;
           this.password = password;
        }
    }
}
