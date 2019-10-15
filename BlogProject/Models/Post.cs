using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Post
    {
        [Key] public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }

        public IList<PostTag> PostTags { get; set; }

        [ForeignKey("CategoryId")] public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Post()
        {

        }
        public Post(string title, string body, string author, DateTime publishDate)
        {
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
        }
    }
}
