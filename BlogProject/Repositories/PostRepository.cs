using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private BlogContext db;

        public PostRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Posts.Count();
        }

        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void Delete(Post post)
        {
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public void Edit(Post post)
        {
            db.Posts.Update(post);
            db.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetByID(int id)
        {
            return db.Posts.Single(p => p.PostId == id);
        }

        public IList<Post> GetByCategoryId(int id)
        {
            return db.Posts.Where(p => p.CategoryId == id).ToList();
        }

        public IList<Post> GetByTagId(int id)
        {
            return db.Posts.Where(p => p.CategoryId == id).ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
