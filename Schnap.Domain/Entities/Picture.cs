using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnap.Domain.Entities
{
    public class Picture
    {
        public virtual int picture_id { get; set; }
        public virtual DateTime upload_date { get; set; }
        public virtual string title { get; set; }
        public virtual string description { get; set; }
    }
}
