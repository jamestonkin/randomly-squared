using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squaredrandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> randoList = new List<int>();
            List<int> squaredList = new List<int>();
            for(int i = 0; i < 20; i++)
            {
                randoList.Add(random.Next(1, 50));
            }

            foreach(int randomNumber in randoList)
            {
                Console.WriteLine(randomNumber);
                int squareUp = randomNumber * randomNumber;
                squaredList.Add(squareUp);
            }

            Console.WriteLine("Squared Even numbers");
            Console.WriteLine("=====================");

            foreach (int squaredNumber in squaredList.ToList())
            {
                if (squaredNumber % 2 != 0)
                {
                    squaredList.Remove(squaredNumber);
                }
                else
                {

                    Console.WriteLine(squaredNumber);

                }
            }

            Console.Read();

        }
    }
}
