﻿using Concert.Shared.Entities;


namespace Concert.API.Data
{
	public class SeedDb
	{
		private readonly DataContext _context;

		public SeedDb(DataContext context)
		{
			_context = context;
		}

		public async Task SeedAsync()
		{
			await _context.Database.EnsureCreatedAsync();
			await CheckTicketsAsync();
		}

		public async Task CheckTicketsAsync()
		{
			if (!_context.Tickets.Any())
			{
				for (int i = 0; i <= 50000; i++)
				{
					_context.Tickets.Add(new Ticket { Id = i, FueUsada = false, FechaUso = null, Porteria = null });


				}

				await _context.SaveChangesAsync();
			}
		}
	}
}
