using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SplitCost.Application.Commands;
using SplitCost.Application.Queries;
using SplitCost.Application.Queries.ShoppingList.GetShoppingList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitCost.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShoppingListController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddList(CreateShoppingListCommand command)
        {
            await _mediator.Send(command);
            return CreatedAtAction(nameof(GetList), new { id = command.Id }, null);
        }

        [HttpGet("{id}")]
        public async Task<GetShoppingListQueryResult> GetList(Guid id)
        {
            return await _mediator.Send(new GetShoppingListQuery() { Id = id});
        }
    }
}
