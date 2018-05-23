using System;
using System.Collections.Generic;
using System.Text;

namespace _08CollectionExercise
{
    class Penguin: Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly!");
        }

        public override string ToString()
        {
            return "A penguin named " + base.Name;
        }
    }
}
