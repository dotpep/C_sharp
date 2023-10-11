using System;

namespace HomeWork3
{
    class Laptop
    {
        public string name;
        public string properties;
        public int cost;
        public double discount;
        public int deliver_cost;


        public Laptop(string name, string properties, int cost, int discount, int deliver_cost)
        {
            this.name = name;
            this.properties = properties;
            this.cost = cost;
            this.discount = discount;
            this.deliver_cost = deliver_cost;
        }


        ~Laptop()
        {

        }


        public void Info()
        {
            Console.WriteLine("Information about Laptop");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Properties: {properties}");
            Console.WriteLine($"Cost: {cost}$");
            Console.WriteLine($"Discount: {discount}%");
            Console.WriteLine($"Deliver cost: {deliver_cost}$");
        }


        public int Sum()
        {
            double disc_convert = discount / 100;
            double with_discount = cost - (cost * disc_convert);
            Console.WriteLine($"Total Sum: {with_discount + deliver_cost}$");
            return 0;
        }

    }
}
