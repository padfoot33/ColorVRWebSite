using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorVRWebSite.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace ColorVRWebSite.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<PlayGrounds> playGrounds { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
