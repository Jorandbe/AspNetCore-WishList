using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region Properties

        public DbSet<Item> Items { get; set; }

        #endregion Properties

        #region Constructors + Destructors

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        #endregion Constructors + Destructors
    }
}
