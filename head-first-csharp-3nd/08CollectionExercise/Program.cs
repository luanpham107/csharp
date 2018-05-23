using System;
using System.Collections.Generic;

namespace _08CollectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cardList = new List<Card>();
            Console.WriteLine("Before sorting:");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                cardList.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                Console.WriteLine(cardList[i].Name);
            }


            Console.WriteLine("After sorting:");
            Console.WriteLine();
            CardComparer_byValue comparer = new CardComparer_byValue();
            cardList.Sort(comparer);
            foreach (Card c in cardList)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine();
            Console.WriteLine("IEnummerable test");
            Console.WriteLine();

            List<Duck> ducks = new List<Duck>() { };
            IEnumerable<Bird> upcastDucks = ducks;

            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(upcastDucks);
            birds.Add(new Penguin() { Name = "George"});

            foreach (Bird bird in birds)
                Console.WriteLine(bird);



            Console.ReadKey();
        }
    }
}
