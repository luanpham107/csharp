using System;
using System.Collections.Generic;
using System.Text;

namespace _08CollectionExercise
{
    class Bird
    {
    public string Name { get; set; }
    public virtual void Fly()
    {
        Console.WriteLine("Flap, flap");
    }
    public override string ToString()
    {
        return "A bird named " + Name;
    }

}
}
