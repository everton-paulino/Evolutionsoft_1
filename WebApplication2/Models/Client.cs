using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Enum;

namespace WebApplication2.Models
{
    public class Client : BaseClass
    {
        public Client()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public long CPF { get; set; }
        public string NameClient { get; set; }
        public string EmailClient { get; set; }
        public int? PostalCode { get; set; }
        public string? Address { get; set; }
        public string? Complement { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public State? States { get; set; }
        public Contact Contacts { get; set; }
    }
}
