using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramArrayConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nHello!\nHow many array elements do you want to create?");
            Console.Write($"\nPlease enter the value:\t "); 
            int elementsCount1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nYou have created an array of {elementsCount1} elements");
            int[] cwArray = new int [elementsCount1];
            Console.WriteLine($"\nNow, you have to inicialized ich of them!!!");

            for (int i = 0; i < cwArray.Length; i++)
            {
                Console.Write($"\nEnter the array element under the index {i} : ");
                cwArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nCongratulations,you have created an array : ");

            for (int i = 0; i < cwArray.Length; i++)
            {
                Console.WriteLine($"\n{ cwArray[i]}");
            }
            Console.WriteLine("\nWell done!!!");
            Console.ReadKey();
        }
    }
}
