using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class EmployeeLoginPassword
    {
        public EmployeeLoginPassword(string login, string password)
        {
            Login = login; 
            Password = password;
        }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
