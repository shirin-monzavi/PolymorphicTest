using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Cat : Animal
    {
        public Cat(int weight) : base(weight)
        {
        }

        public override Cat Create(IContravariant<Cat> cat)
        {
           return new Cat(10);    
        }
    }
}
