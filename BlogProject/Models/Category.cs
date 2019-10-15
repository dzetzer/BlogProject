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

        public virtual IList<Post> Posts { get; set; }
    }
}
