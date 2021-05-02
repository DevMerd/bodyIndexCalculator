using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bodyIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight,bmi;


            Console.Write("Enter your weight: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in meters (Ex 1,73) : ");
            height = Convert.ToDouble(Console.ReadLine());
          
            bmi = weight/(height * height);
            Console.WriteLine("|-----------------|");
            if (bmi < 18.5)
                Console.WriteLine("Low Weight");

            else if (18.5 < bmi && bmi < 25)
                Console.WriteLine("Normal Weight");

            else if (25 < bmi && bmi < 30)
                Console.WriteLine("1st degree Obesity");

            else if (30 < bmi && bmi < 35)
                Console.WriteLine("2nd degree Obesity");

            else if (35 < bmi && bmi < 40)
                Console.WriteLine("3rd degree Obesity");

            else
                Console.WriteLine("4th degree Obesity");


            Console.ReadKey();
        }
    }
}
