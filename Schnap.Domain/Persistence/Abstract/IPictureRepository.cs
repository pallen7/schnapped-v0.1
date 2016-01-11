using Schnap.Domain.Persistence.Entities;
using System.Collections.Generic;

namespace Schnap.Domain.Persistence.Abstract
{
    public interface IPictureRepository
    {
        IEnumerable<Picture> Get();
        Picture GetById(int id);
        void Insert(Picture picture);
        void Update(Picture picture);
        void Delete(int id);
    }
}
