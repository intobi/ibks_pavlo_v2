namespace angulerApp.BLL.DTO.Ticket
{
    public class TicketForListPageDto
    {
        public long Id { get; set; }

        public string? Title { get; set; }

        public string Status { get; set; } = null!;

        public string Type { get; set; } = null!;

        public string? Module { get; set; }
    }
}
