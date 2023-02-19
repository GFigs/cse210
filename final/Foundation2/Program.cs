using System;

class Program
{
    static void Main(string[] args)
    {
        Customer custm1 = new Customer("Peter Griphin", "N street 25", "San Antonio", "Texas", "USA");
        Customer custm2 = new Customer("Damian Diaz", "Uruguay 234", "Mar del Plata", "Buenos Aires", "Argentina");

        Product prod1 = new Product("Videocard", 5552, 1200, 1);
        Product prod2 = new Product("HeadSet", 6245, 150, 2);
        Product prod3 = new Product("Funko pop", 1220, 50, 10);
        Product prod4 = new Product("Book: The Final Empire", 9875, 15, 1);

        Order ord1 = new Order(custm1);
        ord1.AddProduct(prod1);
        ord1.AddProduct(prod2);

        Order ord2 = new Order(custm2);
        ord2.AddProduct(prod3);
        ord2.AddProduct(prod4);

        ord1.PackingLabel();
        ord1.ShippingLabel();
        Console.WriteLine(ord1.GetTotalAmount());

        ord2.PackingLabel();
        ord2.ShippingLabel();
        Console.WriteLine($"${ord2.GetTotalAmount()}");
    }
}