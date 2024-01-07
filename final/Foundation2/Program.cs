using System;

class Program
{
    static void Main(string[] args)
    {
        
        // product
        Product p1 = new Product("Phone charger", "C1234", 29.99, 3);
        Product p2 = new Product("HD Tablet", "T9876", 399.99, 2);
        Product p3 = new Product("3-D printer","P45834", 499.99, 1);
        
        // Address
        Address a1 = new Address("234 Main", "Las Vegas", "NV", "USA");
        Address a2 = new Address("678 Washington", "Salt Laek", "UT", "USA");

        //Customer
        Customer c1 = new Customer("John Hopkins");
        Customer c2 = new Customer("Joseph Smith");

        //order
        //Order o1 = new Order.Add.c1
        
        p1.PackingLabel();
        c1.GetCustomer("John Hopkins");
        Console.WriteLine(a1);
        a1.GenAddress("234 Main", "Las Vegas", "NV", "USA");
        
        
    }
}