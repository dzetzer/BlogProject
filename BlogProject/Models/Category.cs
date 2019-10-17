using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Category
    {
        [Key] public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public Category()
        {

        }

        public Category(int CategoryId, string Name)
        {
            this.CategoryId = CategoryId;
            this.Name = Name;
        }
    }
}
