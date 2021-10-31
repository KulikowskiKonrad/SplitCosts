using MediatR;
using SplitCost.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SplitCost.Application.Queries.ShoppingList.GetShoppingList
{
    public class GetShoppingListQueryHandler : IRequestHandler<GetShoppingListQuery, GetShoppingListQueryResult>
    {
        private readonly IShoppingListRepository _shoppingListRepository;

        public GetShoppingListQueryHandler(IShoppingListRepository shoppingListRepository)
        {
            _shoppingListRepository = shoppingListRepository;
        }

        public async Task<GetShoppingListQueryResult> Handle(GetShoppingListQuery request, CancellationToken cancellationToken)
        {
            var listFromDb = await _shoppingListRepository.GetByIdAsync(request.Id);
            var shoppingList = new GetShoppingListQueryResult()
            {
                Id = listFromDb.Id,
                Name = listFromDb.Name
            };
            return shoppingList;
        }
    }
}
