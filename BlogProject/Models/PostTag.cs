using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class PostTag
    {
        [ForeignKey("PostId")] public int PostId { get; set; }
        public virtual Post Post { get; set; }

        [ForeignKey("TagId")]  public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
