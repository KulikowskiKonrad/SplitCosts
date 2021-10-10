using MediatR;
using SplitCost.Domain.Entities;
using SplitCost.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SplitCost.Application.Commands
{
    public class CreatShoppingListCommand : IRequest
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
    }

    public class CreatShoppingListCommandHandler : IRequestHandler<CreatShoppingListCommand>
    {
        private readonly IShoppingListRepository _shoppingListRepository;

        public CreatShoppingListCommandHandler(IShoppingListRepository shoppingListRepository)
        {
            _shoppingListRepository = shoppingListRepository;
        }

        public async Task<Unit> Handle(CreatShoppingListCommand request, CancellationToken cancellationToken)
        {
            var shoppingList = new ShoppingList(request.Id, request.Name);
            await _shoppingListRepository.AddAsync(shoppingList);

            return Unit.Value;
        }
    }
}
