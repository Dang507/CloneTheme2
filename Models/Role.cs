using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class Role 
    {
        public int RoleId { get; set; }
        public string Roles { get; set; }
        public ICollection<Customer>Customers { get; set; }


    }
}
