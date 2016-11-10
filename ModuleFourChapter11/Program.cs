using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ModuleFourChapter11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indexer methods
            CarDealer cart = new CarDealer();
            Console.WriteLine("Car index 1: " + cart[1]);

            Console.WriteLine("Change the name of car index 1 to Telsa and quantity to 4");
            cart[1] = "Tesla";
            cart[1] = cart["Tesla", 4];
            Console.WriteLine("Car index 1: " + cart[1]);
            

            Console.WriteLine("Engine data");
            int c = 700;
            double k = (int)c;// Explicit conversion of data
            engine newEngine1 = new engine(1, "Bentley", k);
            engine newEngine2 = new engine(2, "Toyota", 300);
            //Overload methods
            Console.WriteLine(newEngine1+newEngine2.ToString());

            engine eg = newEngine1 + newEngine2;
            Console.WriteLine("Average horsepower of the two engines: {0}",eg);
            Console.WriteLine("Most Powerful Engine {0}", newEngine1<newEngine2);
            ////////////////
            Console.WriteLine("\n\tExtention methods");
            string test1 = "Test Word";
            string result = test1.upperCaseString();
            Console.WriteLine(result);
            ///////////////////
            Console.WriteLine("\n \tAnonomous types");
            Predicate<CarDealer> findADealer = new Predicate<CarDealer>(FindCar(cart, "Toyota"));

            
            //////////////
            Console.ReadKey();
        }
    }
}
