using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EFMigrations
{
    public class K20Context : DbContext
    {
        public DbSet<Editora> Editoras { get; set; }
    }
}
