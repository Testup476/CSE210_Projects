using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        // Create 2 Products

        Product product1= new Product("Sandwitch",10,999.99f,4);
        Product product2= new Product("Meal",20,1200.01f,9);

        Address address= new Address("89B Main st","Anyton","Anystate","USA");

        Customer customer= new Customer("Alice",address);

        Order order= new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine("Order Total Cost: $" + order.TotalCost());
        Console.WriteLine("Packing Lable \n" + order.GetPackingLabel());
        Console.WriteLine(" Shipping Label \n" +order.GetShippingLabel());
    }
}