using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class CustomerRole
    {
        public int CustomerId { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public int RoleId { get; set; }
        public ICollection<Role> Roles { get; set; }

    }


}
