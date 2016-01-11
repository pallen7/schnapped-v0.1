using Schnap.Domain.Entities;
using System.Collections.Generic;

namespace Schnap.Domain.Abstract
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
