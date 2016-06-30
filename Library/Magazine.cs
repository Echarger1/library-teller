using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Magazine : Media
    {
        public override int RentalLength
        {
            get
            {
                return 12;
            }

            // Doesn't do anything
            set
            {
            }
        }

        public override void PrintMediaDetails()
        {
            Console.WriteLine("Magazine {0}", Title);
            Console.WriteLine("Magazine {0}", Length);
            Console.WriteLine("Magazine {0}", RentendDate);
            Console.WriteLine("Magazine due on: {0}", ReturnDueDate());
        }

        public override DateTime ReturnDueDate()
        {
            return RentendDate.AddDays(RentalLength);
        }
    }
}
