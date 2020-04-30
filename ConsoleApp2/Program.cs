using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {
            Ui ui = new Ui();

            Customer Mary = ui.CreateCustomer();
            Mary.Print();

            Product apple = ui.CreateProduct();
            Product orange = ui.CreateProduct();
            Product pear = ui.CreateProduct();


            List<Product> products = new List<Product>
            {
                apple,
                pear,
                orange
            };


            int howManyLow = 0;
            int howManyMedium = 0;
            int howManyHigh = 0;
            foreach (Product p in products)
            {
                Console.WriteLine(p.GetCalculateAge());
                if (p.GetCalculateAge() == "low") howManyLow++;
                if (p.GetCalculateAge() == "medium") howManyMedium++;
                if (p.GetCalculateAge() == "high") howManyHigh++;

            }
            Console.WriteLine($"howManyLow= {howManyLow}");
            Console.WriteLine($"howManyMedium= {howManyMedium}");
            Console.WriteLine($"howManyHigh= {howManyHigh}");

        }

    }
}

