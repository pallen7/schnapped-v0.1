using Schnap.Domain.Abstract;
using Schnap.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnap.Domain.Concrete
{
    public class PictureRepository : IPictureRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Picture> pictures
        {
            get { return context.pictures; }
        }
    }
}
