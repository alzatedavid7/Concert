using Concert.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Concert.API.Controllers
{
	[ApiController]
	[Route("/api/Tickets")]
	public class TicketsController : ControllerBase
	{
		private readonly DataContext _context;

		public TicketsController(DataContext context)
		{
			_context = context;
		}

		//

		[HttpGet("{id:int}")]
		public async Task<ActionResult> GetAsync(int id)
		{
			var Ticket = await _context.Tickets.FirstOrDefaultAsync(x => x.Id == id);

			if (Ticket is null)
			{
				return BadRequest("Boleta no valida");
			}

			return Ok(Ticket);
		}

	}
}
