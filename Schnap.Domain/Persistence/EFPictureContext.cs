﻿using Schnap.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnap.Domain.Persistence
{
    public class EFPictureContext : DbContext
    {
        public DbSet<Picture> pictures { get; set; }
    }
}
