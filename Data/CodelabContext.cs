using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codelab.DLL.Data
{
     
      public  class CodelabContext:IdentityDbContext
    {
        public CodelabContext(DbContextOptions<CodelabContext> o) : base(o)
        { }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseOrder> CourseOrder { get; set; }
        public DbSet<User> User{ get; set; }
    }
}
