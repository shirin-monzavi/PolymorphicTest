using Liskov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestAnimal : Animal
    {
        public TestAnimal(int weight) : base(weight)
        {
        }

        public override Animal Create(IContravariant<Cat> cat)
        {
            throw new NotImplementedException();
        }
    }
}
