using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class Customer 
    {

        public Customer()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }
        public int CustomerId { get; set; }       
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public Guid CustomerGuid { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }         
        public DateTimeOffset LatestUpdatedOn { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }     
        public virtual ICollection<Post>Posts {get;set;}
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Comment>Comments { get; set; }
        public ICollection<Role> Roles { get; set; }

    }
}
