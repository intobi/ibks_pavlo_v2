using angularApp.DAL.Repositories.TicketReplys;
using angulerApp.BLL.DTO.TicketReply;
using AutoMapper;
using Infrastructure.Models;

namespace angulerApp.BLL.Services.TicketReplys
{
    public class TicketReplyService : ITicketReplyService
    {
        private readonly ITicketReplyRepository ticketReplyRepository;
        private readonly IMapper mapper;

        public TicketReplyService(ITicketReplyRepository ticketReplyRepository, IMapper mapper)
        {
            this.ticketReplyRepository = ticketReplyRepository;
            this.mapper = mapper;
        }

        public async Task CreateTicketReplyAsync(TicketReplyDto ticketReplyDto)
        {
            var ticketReply = this.mapper.Map<TicketReply>(ticketReplyDto);
            await this.ticketReplyRepository.CreateAsync(ticketReply);
        }

        public async Task<List<TicketReplyForListDto>> GetRepliesByTicketId(long ticketId)
        {
            var replies = await this.ticketReplyRepository.GetAllByTickedIdAsync(ticketId);
            var result = this.mapper.Map<List<TicketReplyForListDto>>(replies);
            return result;
        }
    }
}
