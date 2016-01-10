using Schnap.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnap.Domain.Abstract
{
    public interface IPictureRepository
    {
        IEnumerable<Picture> pictures;
    }
}
