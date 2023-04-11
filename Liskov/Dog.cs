using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Dog : Animal
    {
        public Dog(int weight) : base(weight)
        {
        }

        public override Dog Create(IContravariant<Cat> cat)
        {
            return new Dog(10);
        }

        public override int CalculateMedicineDoze()
        {
            return base.CalculateMedicineDoze();
        }

        public override Animal Create1(Cat cat)
        {
            throw new NotImplementedException();
        }

        public override Animal Create2(Action<Cat> cat)
        {
            throw new NotImplementedException();
        }
    }
}
