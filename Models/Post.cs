using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class Post
    {
        public Post()
        {
            CreateOn = DateTimeOffset.Now;
            UpdateOn = DateTimeOffset.Now;
        }
        public DateTimeOffset CreateOn { get; set; }
        public DateTimeOffset UpdateOn { get; set; }
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string Content { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Image>Images { get; set; }

       public ICollection<Category> Categories { get; set; }
    }
}
