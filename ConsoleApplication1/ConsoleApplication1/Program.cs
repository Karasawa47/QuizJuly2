using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int num1;
            int num2;
            Console.WriteLine("Enter a number:");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            num2=int.Parse(Console.ReadLine());
            Console.Write("the smaller number is: ");
            int result=CompareInt(num1,num2);
            Console.Write(result+"");
            Console.ReadKey();

        }

        public static int CompareInt(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
                return num2;
        }
    }
}
