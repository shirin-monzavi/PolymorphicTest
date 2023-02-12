using Liskov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class TestTest
    {
        Func<Cat, Cat> f1;

        [Fact]
        public void Test1()
        {
            Func<Animal> _base = () => new Cat(100).Create1(new Cat(5));
            //_base.Invoke().Create1(_base.);
            //Func<Dog, Animal> f1 = cat.Create1;
            //Func<Cat, Animal> f2 = cat.Create1;
        }

        [Fact]
        public void Test2()
        {
            var cat = new Cat(100);
            IContravariant<Animal> animal = new Liskov.Contravarient();
            cat.Create(animal);
        }

        [Fact]
        public void Test5()
        {
            var cat = new Cat(100);
            Action<Animal> action = a => { };
            cat.Create2(action);
            cat.Create2(x => { });
        }

        [Fact]
        public void Test6()
        {
            var cat = new Cat(100);

            f1 = cat.Create1;
            f1.Invoke(cat);
            f1 += CreateTest;
            //f1.Invoke()

        }

        public Cat CreateTest(Animal cat)
        {
            return new Cat(5);
        }

        [Fact]
        public void Test3()
        {
            var cat = new Cat(100);

            cat.Create2(cat => new a)

        }


    }
}
