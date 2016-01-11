using Schnap.Domain.Persistence.Entities;
using System.Collections.Generic;

namespace Schnap.Client.Models
{
    public class PictureListViewModel
    {
        public IEnumerable<Picture> pictures { get; set; }
        public PagingInfo paging_info { get; set; }
    }
}