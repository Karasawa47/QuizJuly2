using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Book
    {
        public float Price { get; set; }
        public string Name { get; set; }
        public int BookCompare(Book OtherBook){
            if (this.Price > OtherBook.Price) {
                return 1;
            }
            else if (this.Price == OtherBook.Price)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }

}
