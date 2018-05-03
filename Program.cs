using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
               Start();
        }

        public static void Start()
        { 

            Tiger Tiger = new Tiger(95, 200, 55, "Tiger");
            Tiger.Description();

            Lion Lion = new Lion(120, 190, 70, "Lion");
            Lion.Description();

            Leopard Leopard = new Leopard(65, 31, 50, "Leopard");
            Leopard.Description();

            Console.ReadLine();

            List<Object> BreedList = new List<Object>();
            BreedList.Add(Tiger);
            BreedList.Add(Lion);
            BreedList.Add(Leopard);

            Pantherinae[] animals = new Pantherinae[] { Tiger, Lion, Leopard };


            var breedSort = from a in animals
                                orderby a.breed
                                select a;

            Console.WriteLine("The names of cats in alphabetical order:\n");
            foreach (Pantherinae b in breedSort)
            Console.WriteLine(b.breed);

            Console.Read();
        }

        
    }
}
