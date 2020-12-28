using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class Category
    {
        public Category()
        {
            CreateOn = DateTimeOffset.Now;
            UpdateOn = DateTimeOffset.Now;
        }
        public DateTimeOffset CreateOn { get; set; }
        public DateTimeOffset UpdateOn { get; set; }
        public int Id { get; set; }
        public string CategoryName { get; set; }
       public ICollection<Post>Posts { get; set; }
       

    }
}
