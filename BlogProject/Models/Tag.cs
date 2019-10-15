﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Tag
    {
        [Key] public int TagId { get; set; }
        public string Name { get; set; }

        public virtual IList<PostTag> PostTags { get; set; }
    }
}
