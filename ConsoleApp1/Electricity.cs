using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Electricity
    {
        static void Main(string[] args)
        {
            double bill = 0;
            Console.WriteLine("Enter the customer id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the customer name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the customer unit");
            double unit = Convert.ToDouble(Console.ReadLine());
            if (unit <= 199)
            {
              bill = 1.20 * unit;
            }
            else if(unit>=200 && unit < 400)
            {
                bill = 1.50*unit;
            }
            else if(unit>=400 && unit < 600)
            {
                bill = 1.80 * unit;
            }
            else if (unit >= 600)
            {
                bill = 2.00 * unit;
            }
            if(bill > 400)
            {
                bill += (15 / 100) * bill;
            }
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(unit);
            Console.WriteLine("the bill is "+bill);

        }
    }
}
