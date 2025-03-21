using angulerApp.BLL.DTO.Ticket;

namespace angulerApp.BLL.Services.Tickets
{
    public interface ITicketService
    {
        Task<List<TicketForListPageDto>> GetAllTicketsAsync();

        Task<EditCreateTicketDto> GetTicketForEditAsync(long id);

        Task UpdateTicketAsync(EditCreateTicketDto ticket);

        Task CreateTicketAsync(EditCreateTicketDto ticketDto);
    }
}
