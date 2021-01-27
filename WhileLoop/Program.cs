using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Learning While Loop
            
            int i = 10;
            while (i<15)
            {
                Console.WriteLine("Number will increase from 10 to 14 by one "+ i);
                i++;
            }
           
            Console.WriteLine();
            


            // Example #2

            Console.WriteLine("This is where the second loop Start from 0 to 10");
           
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine();



            // Example #3
            Console.WriteLine("This is where third example start fro 5 to 0");
            int k = 5;
            while (k >= 0)
            {
                Console.WriteLine(k);
                k--;
            }
            Console.WriteLine();


            //Example 4
            int l = 0;
            while (l == 0)
            {
                Console.WriteLine("Done");
                l++;
            }
        }
    }
}
