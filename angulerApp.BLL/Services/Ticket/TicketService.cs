using angularApp.DAL.Repositories.Tickets;
using angulerApp.BLL.DTO.Ticket;
using AutoMapper;
using Infrastructure.Models;

namespace angulerApp.BLL.Services.Tickets
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository ticketRepository;
        private readonly IMapper mapper;

        public TicketService(ITicketRepository ticketRepository, IMapper mapper)
        {
            this.ticketRepository = ticketRepository;
            this.mapper = mapper;
        }

        public async Task<List<TicketForListPageDto>> GetAllTicketsAsync()
        {
            var tickets = await this.ticketRepository.GetAllAsync();
            var result = this.mapper.Map<List<TicketForListPageDto>>(tickets);
            return result;
        }

        public async Task<EditCreateTicketDto> GetTicketForEditAsync(long id)
        {
            var ticket = await this.ticketRepository.GetOneByIdAsync(id);
            var result = this.mapper.Map<EditCreateTicketDto>(ticket);
            return result;
        }

        public async Task UpdateTicketAsync(EditCreateTicketDto ticketDto)
        {
            var ticket = this.mapper.Map<Ticket>(ticketDto);
            await this.ticketRepository.UpdateTicketAsync(ticket);
        }

        public async Task CreateTicketAsync(EditCreateTicketDto ticketDto)
        {
            var ticket = this.mapper.Map<Ticket>(ticketDto);
            await this.ticketRepository.CreateTicketAsync(ticket);
        }
    }
}
