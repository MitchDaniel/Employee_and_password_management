using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Employee
    {
        public Employee(string fullname, string workPosition) 
        { 
            Fullname = fullname;
            WorkPosition = workPosition;
        }

        public string Fullname { get; set; }

        public string WorkPosition{ get; set; }

        public override string ToString()
        {
            return $"{Fullname}, {WorkPosition}";
        }
    }
}
