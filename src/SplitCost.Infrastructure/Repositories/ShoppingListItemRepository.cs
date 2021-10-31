using SplitCost.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplitCost.Domain.Repositories;

namespace SplitCost.Infrastructure.Repositories
{
    internal class ShoppingListItemRepository : IShoppingListItemRepository
    {
        private readonly SplitCostDbContext _dbContext;

        public ShoppingListItemRepository(SplitCostDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(ShoppingListItem shoppingListItem)
        {
            await _dbContext.AddAsync(shoppingListItem);
            await _dbContext.SaveChangesAsync();
        }
    }
}
