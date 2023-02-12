using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    delegate void personDelegate(Employee employee);
    public class Employee : Person
    {
        public void Greet(Person person)
        {
            personDelegate personDelegate = Greet;
        }
    }
}
