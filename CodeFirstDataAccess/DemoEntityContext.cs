using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CMS.ENTITY;

namespace CMS.DATAACCESS
{
    public class CMSContext : DbContext
    {
        public CMSContext()
            : base("name=DbConnectionString")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
