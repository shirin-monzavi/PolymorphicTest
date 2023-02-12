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

        public override Cat Create1(Cat cat)
        {
            return new Cat(5);
        }

        public override Animal Create2(Action<Cat> setup)
        {
            var res = new Cat(5);
            setup(res);
            return res;
        }
    }

    public class Small { };
    public class Big : Small { }
    public class Bigger : Big { }

    public  class Launcher 
    {
        delegate Small CoverDel(Big big);



    }



}
