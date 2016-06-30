using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : Media
    {
        public override int RentalLength
        {
            get
            {
                return 21;
            }

            //Doesn't do anything
            set
            {
            }
        }

        public override void PrintMediaDetails()
        {
            Console.WriteLine("Book {0}", Title);
            Console.WriteLine("Book {0}", Length);
            Console.WriteLine("Book {0}", RentendDate);
            Console.WriteLine("Book due on: {0}", ReturnDueDate()); ;
        }

        public override DateTime ReturnDueDate()
        {
            return RentendDate.AddDays(RentalLength);
        }
    }
}
