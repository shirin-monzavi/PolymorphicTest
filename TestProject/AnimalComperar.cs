using Liskov;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class AnimalComperar : IComparer<Animal>
    {
        public int Compare(Animal? x, Animal? y)
        {
            throw new NotImplementedException();
        }
    }
}
