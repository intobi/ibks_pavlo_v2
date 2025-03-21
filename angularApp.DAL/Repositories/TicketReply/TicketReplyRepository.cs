using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace angularApp.DAL.Repositories.TicketReplys
{
    public class TicketReplyRepository : ITicketReplyRepository
    {
        private readonly ApplicationDbContext context;

        public TicketReplyRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(TicketReply ticketReply)
        {
            this.context.TicketReplies.Add(ticketReply);
            await this.context.SaveChangesAsync();
        }

        public async Task<List<TicketReply>> GetAllByTickedIdAsync(long tickedId)
        {
            var result = await this
                .context.TicketReplies.Where(x => x.Tid == tickedId)
                .ToListAsync();
            return result;
        }
    }
}
