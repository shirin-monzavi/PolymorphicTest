namespace Liskov
{

    public abstract class Animal
    {
        public Animal(int weight)
        {
            Weight = weight;
        }
        public abstract Animal Create(IContravariant<Cat> cat);

        public abstract Animal Create2(Action<Cat> cat);

        public abstract Animal Create1(Cat cat);

        public virtual int CalculateMedicineDoze()
        {
            return Weight * 2;
        }
        public int Weight { get; }

    }
}