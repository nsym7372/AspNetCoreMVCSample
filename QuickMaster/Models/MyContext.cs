using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMaster.Models
{
    using Microsoft.EntityFrameworkCore;
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> option) : base(option) { }

        public DbSet<Book> Books { get; set; }
    }
}
