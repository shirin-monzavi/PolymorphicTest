using Liskov;
using System;
using Xunit;

namespace TestProject
{
    public abstract class AnimalTest<T> where T :  Animal
    {
        //private T sut;


        public T Make(int w)
        {
            return (T)Activator.CreateInstance(typeof(T), w);
        }
        [Fact]
        public void Test1()
        {
            var testAnimal = Make(100);
            var actual = testAnimal.CalculateMedicineDoze();
            Assert.Equal(200, actual);

        }

        [Fact]
        public void Test2()
        {
            var testAnimal = Make(100);
            //var actual = testAnimal.Create2(c=>testAnimal);
            // Func<Animal> _base = () => new Cat(100).Create1(Make(100));
            //_base.Invoke().Create1(_base.);
            //Func<Dog, Animal> f1 = cat.Create1;
            //Func<Cat, Animal> f2 = cat.Create1;
        }
    }
}