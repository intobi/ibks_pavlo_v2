using Infrastructure.Models;

namespace angularApp.DAL.Repositories.Tickets
{
    public interface ITicketRepository
    {
        Task<List<Ticket>> GetAllAsync();

        Task<Ticket> GetOneByIdAsync(long id);

        Task UpdateTicketAsync(Ticket ticket);

        Task CreateTicketAsync(Ticket ticket);
    }
}
