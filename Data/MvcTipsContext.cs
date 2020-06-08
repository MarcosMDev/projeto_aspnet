using Microsoft.EntityFrameworkCore;
using MvcTips.Models;

namespace MvcTips.Data
{
    public class MvcTipsContext : DbContext
    {
        public MvcTipsContext (DbContextOptions<MvcTipsContext> options)
            : base(options)
        {
        }

        public DbSet<Tips> Tips { get; set; }
    }
}