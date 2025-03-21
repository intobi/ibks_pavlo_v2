using angulerApp.BLL.DTO.Ticket;
using angulerApp.BLL.DTO.TicketReply;
using angulerApp.BLL.Services.TicketReplys;
using angulerApp.BLL.Services.Tickets;
using Infrastructure.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService ticketService;
        private readonly ITicketReplyService ticketReplyService;

        public TicketsController(
            ITicketService ticketService,
            ITicketReplyService ticketReplyService
        )
        {
            this.ticketReplyService = ticketReplyService;
            this.ticketService = ticketService;
        }

        [HttpGet]
        public async Task<ActionResult> Get() => Ok(await this.ticketService.GetAllTicketsAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(long id) =>
            Ok(await this.ticketService.GetTicketForEditAsync(id));

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTicket(long id, [FromBody] EditCreateTicketDto ticket)
        {
            await this.ticketService.UpdateTicketAsync(ticket);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CreateTicket([FromBody] EditCreateTicketDto ticket)
        {
            await this.ticketService.CreateTicketAsync(ticket);
            return Ok();
        }

        [HttpPost("reply/{id}")]
        public async Task<ActionResult> CreateTicketReply(long id, [FromBody] TicketReplyDto reply)
        {
            await this.ticketReplyService.CreateTicketReplyAsync(reply);
            return Ok();
        }

        [HttpGet("replies/{id}")]
        public async Task<ActionResult> GetAllTicketReplies(long id) =>
            Ok(await this.ticketReplyService.GetRepliesByTicketId(id));
    }
}
