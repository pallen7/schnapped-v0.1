using Schnap.Domain.Persistence.Abstract;
using Schnap.Domain.Persistence.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Schnap.Domain.Persistence.Concrete
{
    public class PictureRepository : IPictureRepository
    {

        EFDbContext context = new EFDbContext();

        public IEnumerable<Picture> Get()
        {
            return context.pictures;
        }

        public Picture GetById(int id)
        {
            return context.pictures.FirstOrDefault(p => p.id == id);
        }

        public void Insert(Picture picture)
        {
            context.pictures.Add(picture);
        }

        public void Update(Picture picture)
        {
            context.Entry(picture).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var picture = context.pictures.FirstOrDefault(p => p.id == id);
            context.pictures.Remove(picture);
        }
    }
}
