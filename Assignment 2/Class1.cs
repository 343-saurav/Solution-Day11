using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
     class Class1
    {
        readonly string pCode;
        string pName;
        int qty_in_stock;
        float discount_allowed;
        static string brand;
        public void GetDetails()
        {
            Console.WriteLine("Enter pName");
            this.pName = Console.ReadLine();
            Console.WriteLine("Enter qty_in_stock");
            this.qty_in_stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Discount Allowed");
            this.discount_allowed = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Pcode is : {pCode}");
            Console.WriteLine($"PName is : {pName}");

            Console.WriteLine($"Qauntity in stock is : {qty_in_stock}");
            Console.WriteLine($"Discount Allowed is : {discount_allowed}");
        }


    }
}
