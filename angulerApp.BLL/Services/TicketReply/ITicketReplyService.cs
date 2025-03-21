using angulerApp.BLL.DTO.TicketReply;

namespace angulerApp.BLL.Services.TicketReplys
{
    public interface ITicketReplyService
    {
        Task CreateTicketReplyAsync(TicketReplyDto ticketDto);

        Task<List<TicketReplyForListDto>> GetRepliesByTicketId(long ticketId);
    }
}
