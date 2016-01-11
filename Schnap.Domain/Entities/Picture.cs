using System;

namespace Schnap.Domain.Entities
{
    public class Picture
    {
        public virtual int id { get; set; }
        public virtual DateTime upload_date { get; set; }
        public virtual string title { get; set; }
        public virtual string description { get; set; }
    }
}
