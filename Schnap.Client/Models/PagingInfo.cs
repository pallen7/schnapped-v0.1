using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schnap.Client.Models
{
    public class PagingInfo
    {
        public int total_items { get; set; }
        public int items_per_page { get; set; }
        public int current_page { get; set; }

        public int total_pages
        {
            get { return (int)Math.Ceiling((decimal)total_items / items_per_page); }
        }
    }
}