using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class DVD : Media
    {
        public override int RentalLength
        {
            get
            {
                return 7;
            }

            // Doesn't do anything
            set
            {
            }
        }

        public override void PrintMediaDetails()
        {
            Console.WriteLine("DVD {0}", Title);
            Console.WriteLine("DVD {0}", Length);
            Console.WriteLine("DVD {0}", RentendDate);
            Console.WriteLine("DVD due on: {0}", ReturnDueDate());
        }

        public override DateTime ReturnDueDate()
        {
            return RentendDate.AddDays(RentalLength);
        }
    }
}
