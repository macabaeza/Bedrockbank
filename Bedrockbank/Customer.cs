using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedrockbank
{
 public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        //multiples accounts for one customer, that is a interfaces that follow an especific patterns
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
