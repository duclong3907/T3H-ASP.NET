using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class NormalEmployee : Employee
    {
        public NormalEmployee(string name, string address)
        {
            Name = name;
            Adrress = address;
        }

        public string Adrress { get; set; }
    }
}
