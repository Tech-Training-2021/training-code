using System;
using AdventureWorksMain.Entities;
using System.Linq;

namespace AdventureWorksMain
{
    class Program
    {
        static void Main(string[] args)
        {
         /*  int[] numbers=new int[]{1,2,3,4,5,6,7,8,9,10};
           foreach (var num in numbers)
           {
               if(num%2 == 0)
                Console.Write($"{num} ");// string interpolation
           }*/
        AdventureWorksDbContext dbContext=new AdventureWorksDbContext();
        var customers= dbContext.Customers;
            foreach (var customer in customers)
            {
                if(customer.CustomerId<11)
                    Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
        }
    }
}
