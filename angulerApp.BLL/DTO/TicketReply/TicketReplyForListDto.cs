namespace angulerApp.BLL.DTO.TicketReply
{
    public class TicketReplyForListDto
    {
        public long Id { get; set; }

        public string Text { get; set; } = null!;

        public DateTime CreatedAt { get; set; }
    }
}
