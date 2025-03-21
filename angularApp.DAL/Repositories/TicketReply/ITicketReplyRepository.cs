using Infrastructure.Models;

namespace angularApp.DAL.Repositories.TicketReplys
{
    public interface ITicketReplyRepository
    {
        Task CreateAsync(TicketReply ticketReply);

        Task<List<TicketReply>> GetAllByTickedIdAsync(long tickedId);
    }
}
