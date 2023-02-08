using Liskov;
using System;
using Xunit;

namespace TestProject
{
    public class AnimalTest<T> where T :  Animal
    {
        private T sut;

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
    }
    public class AnimalTest : AnimalTest<TestAnimal>
    {

    }
}