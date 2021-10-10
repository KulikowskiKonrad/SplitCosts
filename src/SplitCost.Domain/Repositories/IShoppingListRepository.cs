using SplitCost.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitCost.Domain.Repositories
{
    public interface IShoppingListRepository
    {
        Task AddAsync(ShoppingList shoppingList);
    }
}
