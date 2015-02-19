using SPASample.DAO.DBContext;
using SPASample.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SPASample.DAO
{
    public class SPASampleDbContext : DbContext
    {
        public SPASampleDbContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer<SPASampleDbContext>(new SPASampleDbInitializer());
        }

        public SPASampleDbContext()
            : this("SPASampleEntities")
        {

        }

        public DbSet<Screen> Screen { get; set; }
        public DbSet<Field> Field { get; set; }
    }
}