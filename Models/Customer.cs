using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class Customer 
    {

        public Customer()
        {
            CreatedOn = DateTimeOffset.Now;
           UpdatedOn = DateTimeOffset.Now;
        }
        public int CustomerId { get; set; }  
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public Guid CustomerGuid { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }         
        public DateTimeOffset UpdatedOn { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Address { get; set; }     
        public virtual ICollection<Post>Posts {get;set;}
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Comment>Comments { get; set; }
        public ICollection<Role> Roles { get; set; }

    }
}
