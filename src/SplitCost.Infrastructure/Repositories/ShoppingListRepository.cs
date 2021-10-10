using SplitCost.Domain.Entities;
using SplitCost.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitCost.Infrastructure.Repositories
{
    internal class ShoppingListRepository : IShoppingListRepository
    {
        private readonly SplitCostDbContext _dbContext;

        public ShoppingListRepository(SplitCostDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(ShoppingList shoppingList)
        {
            await _dbContext.AddAsync(shoppingList);
            await _dbContext.SaveChangesAsync();
        }
    }
}
