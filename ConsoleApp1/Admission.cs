using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Admission
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            if (maths >= 65 && physics >= 55 && chemistry >= 50 && (maths + physics + chemistry) >= 180 || (maths + physics) >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
