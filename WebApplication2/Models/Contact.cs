using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Contact: BaseClass
    {
        public Contact()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string ContactName { get; set; }
        public long ContactMobile { get; set; }
    }
}
