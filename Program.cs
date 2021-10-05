using System;
using System.Collections.Generic;  

namespace TemplateMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[] { 1, 8, 7 , 4, 6 , 5 , 3 , 9 , 2 };
            int N = 9;

            SorterC sortA = new SorterC();

            sortA.Sort(array,N);

            foreach (int i in array){
                Console.WriteLine(i);
            }
        }
    }
}
