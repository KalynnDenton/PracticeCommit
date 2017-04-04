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

            Console.WriteLine(vacaSpots[0] + " " +  vacaSpots[9]);//Choose ten vacation spots, then print the first and last

            int[] childrenAge = { 3, 6, 1 };//get 3 childrens ages and print them.

            Console.WriteLine("Caleb's age: " + childrenAge[0]);
            Console.WriteLine("June's age: " + childrenAge[1]);
            Console.WriteLine("Autumn's age: " + childrenAge[2]);

            int[] ages = new int[6]; //If elements are unknown. Set length of Array!

            char[] classMateFirstLetter = { 'A', 'S', 'L', 'N' }; //The first letters of name of classmates

            foreach (char letter in classMateFirstLetter)
            {
                Console.WriteLine(letter);
                
            }
        }
    }
}
