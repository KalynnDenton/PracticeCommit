using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day1_DoIt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vacaSpots = { "Hawaii", "Narita", "Orlando", "Kyoto", "Hakone", "Osaka", "Kamaura", "Yokohama", "Ishigaki", "Shikoku" };

            Console.WriteLine(vacaSpots[0] + " " +  vacaSpots[9]);

            int[] childrenAge = { 3, 6, 1 };

            Console.WriteLine("Caleb's age: " + childrenAge[0]);
            Console.WriteLine("June's age: " + childrenAge[1]);
            Console.WriteLine("Autumn's age: " + childrenAge[2]);

            char[] classMateFirstLetter = { 'A', 'S', 'L', 'N' };

            foreach (char letter in classMateFirstLetter)
            {
                Console.WriteLine(letter);
                
            }
        }
    }
}
