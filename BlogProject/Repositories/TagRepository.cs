using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private BlogContext db;

        public TagRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Tags.Count();
        }

        public void Create(Tag tag)
        {
            db.Tags.Add(tag);
            db.SaveChanges();
        }

        public void Delete(Tag tag)
        {
            db.Tags.Remove(tag);
            db.SaveChanges();
        }

        public void Edit(Tag tag)
        {
            db.Tags.Update(tag);
            db.SaveChanges();
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags.ToList();
        }

        public Tag GetByID(int id)
        {
            return db.Tags.Single(p => p.TagId == id);
        }

        public IEnumerable<Tag> GetByProductID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }

    }
}
