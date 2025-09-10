
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            bool isChild = true;
            Console.WriteLine(isChild);
            
            int myage = 6;
            Console.WriteLine(myage);

            float pi = 3.14f;
            Console.WriteLine(pi);

            string name = "matus";
            Console.WriteLine(name);

            char gender = 'm';
            Console.WriteLine(gender);


            /* int a = 10;
             int b = 5;


             int sum = a / b;
             Console.WriteLine(sum);*/
            
            int birthday = 28;
            int birthmonth = 3;
            int birthyeart = 2010;

            
            int birthsum = birthday + birthmonth + birthyeart;
            Console.WriteLine(birthsum);

            Console.WriteLine(birthsum * 10);

            Console.WriteLine(birthyeart * birthmonth + birthday); 

            /* Console.WriteLine(5f/3f);
             */



            Console.WriteLine(name + (birthday + birthmonth));
        }
    }
}