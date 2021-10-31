using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitCost.Application.Queries.ShoppingList.GetShoppingList
{
    public class GetShoppingListQuery : IRequest<GetShoppingListQueryResult>
    {
        public Guid Id { get; set; }
    }
}
