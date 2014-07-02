using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1=new Book();
            Book book2=new Book();
            Console.WriteLine("Enter first Book Price:");
            book1.Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Book Price:");
            book2.Price = float.Parse(Console.ReadLine());
            Console.WriteLine(book1.BookCompare(book2));
            Console.ReadKey();
        }
    }
}
