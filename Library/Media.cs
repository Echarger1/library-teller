using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Media
    {
        public virtual string Title { get;  set; }
        public virtual string Length { get;  set; }
        public abstract int RentalLength { get; set; }
        protected DateTime RentendDate { get;  set; }
    
        
        public Media()
        {
            RentendDate = DateTime.Today;
        }
        
        public abstract void PrintMediaDetails();

        public abstract DateTime ReturnDueDate();

        public virtual void  SetRentedDate()
        {
            RentendDate = DateTime.Today;
        }
    }
}
