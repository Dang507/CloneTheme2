using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }

        public string Type { get; set; }
         public ICollection<Post> Posts { get; set; }
        
        public Customer Customers { get; set; }
    }
}
