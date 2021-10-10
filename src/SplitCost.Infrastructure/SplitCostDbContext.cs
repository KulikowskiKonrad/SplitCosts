using Microsoft.EntityFrameworkCore;
using SplitCost.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitCost.Infrastructure
{
    public class SplitCostDbContext : DbContext
    {
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<ShoppingListItem> ShoppingListItems { get; set; }

        public SplitCostDbContext(DbContextOptions<SplitCostDbContext> options) : base(options)
        {

        }
    }
}
