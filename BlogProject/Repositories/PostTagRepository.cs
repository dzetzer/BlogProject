using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Repositories
{
    public class PostTagRepository : IRepository<PostTag>
    {
        private BlogContext db;

        public PostTagRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.PostTags.Count();
        }

        public void Create(PostTag postTag)
        {
            db.PostTags.Add(postTag);
            db.SaveChanges();
        }

        public void Delete(PostTag postTag)
        {
            db.PostTags.Remove(postTag);
            db.SaveChanges();
        }

        public void Edit(PostTag postTag)
        {
            db.PostTags.Update(postTag);
            db.SaveChanges();
        }

        public IEnumerable<PostTag> GetAll()
        {
            return db.PostTags.ToList();
        }

        public PostTag GetByTagID(int id)
        {
            return db.PostTags.Single(p => p.TagId == id);
        }

        public PostTag GetByPostID(int id)
        {
            return db.PostTags.Single(p => p.PostId == id);
        }

        public PostTag GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
