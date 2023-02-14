using System;

namespace DemoSplitFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Задание 1
            int[] omas = new int[15];
            int i;
            for (i = 0; i < omas.Length; i++)
            { Console.Write($"omas[{i}]=", i); omas[i] = int.Parse(Console.ReadLine()); }
            for (i = 0; i <omas.Length; i++)
            { Console.Write(" " + omas[i]); }*/


            /*// Задание 2
            int[] omas = {2, 1, 3, 5, 5, 6, 12, 8, 152, 15 };
            int i;
            for(i = 0; i < omas.Length; i++) { Console.WriteLine($"omas-[{i}]={omas[i]}"); }*/


            //Задание 3
            /*int[] Arr;
            Arr = new int[12];
            foreach(int i in Arr) {
            Console.Write(" " + Arr[i]); Arr[i] = i + 1; Console.Write(" " + Arr[i]); Arr[i] = i + 2; }*/



            // Задание 4
            Random rnd = new Random();
            int n = rnd.Next(14);
            int[] myArray = new int[n];
            foreach (int elem in myArray)
            {
                Console.WriteLine("{10} ", elem);
            }
        }

    }
}
