using CrmApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Customer
    {
        private int category;
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Age { get; set; }
        public string Sex { get; set; }
  

public Customer(string name, string surname, decimal age, string sex, int category)
{
          this.Name = name;
          this.Surname = surname;
          this.Age = age;
          this.Sex = sex;
          this.category = category;
}

public Customer()
{

}

public override string ToString()
{
    return $"Name= {Name} Surname={Surname} Age={Age} Sex={Sex}";
}


public void Sale ()
  {
    Product product = new Product();
    Console.WriteLine("Give the name:");
    product.Name = Console.ReadLine();
    Console.WriteLine("Give the price:");
    product.Price = Decimal.Parse(Console.ReadLine());
    Console.WriteLine("Give the quantity:");
    product.Quantity = Int32.Parse(Console.ReadLine());
}

        public void IncreaseAge(decimal percentage)
        {
            if (category == 1)
            {
                Age *= (1 + 0.1m);
            }
            else
            {
                Age *= (1 + percentage);
            }

        }

    public void Print()
    {
        Console.WriteLine(ToString());
        Console.WriteLine();
    }

        public string GetCalculateAge()
        {
            if (Age < 18)
                return "underage";
            if (Age < 70)
                return "adult";

            else
                return "very old";
        }
    }
}


