using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace angularApp.DAL.Repositories.Tickets
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext context;

        public TicketRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Ticket>> GetAllAsync()
        {
            var result = await this
                .context.Tickets.Include(x => x.Status)
                .Include(x => x.TicketType)
                .OrderBy(x => x.Date)
                .ToListAsync();

            return result;
        }

        public async Task<Ticket> GetOneByIdAsync(long id)
        {
            var result =
                await this.context.Tickets.FirstOrDefaultAsync(x => x.Id == id)
                ?? throw new Exception("not found");
            // in general would be nice to have custom exceptions + exception handler in middleware

            return result;
        }

        public async Task UpdateTicketAsync(Ticket ticket)
        {
            var tickeToUpdate = await this.GetOneByIdAsync(ticket.Id);

            tickeToUpdate.Title = ticket.Title;
            tickeToUpdate.StatusId = ticket.StatusId;
            tickeToUpdate.TicketTypeId = ticket.TicketTypeId;
            tickeToUpdate.PriorityId = ticket.PriorityId;
            tickeToUpdate.ApplicationName = ticket.ApplicationName;
            tickeToUpdate.Description = ticket.Description;
            tickeToUpdate.InstalledEnvironmentId = ticket.InstalledEnvironmentId;

            this.context.SaveChanges();
        }

        public async Task CreateTicketAsync(Ticket ticket)
        {
            await this.context.Tickets.AddAsync(ticket);
            this.context.SaveChanges();
        }
    }
}
