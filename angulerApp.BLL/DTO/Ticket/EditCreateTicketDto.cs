namespace angulerApp.BLL.DTO.Ticket
{
    public class EditCreateTicketDto
    {
        public long Id { get; set; }

        public string? Title { get; set; }

        public int Status { get; set; }

        public int Type { get; set; }

        public int UrgentLvl { get; set; } // priority

        public int InstalledEnvironment { get; set; }

        public string? Module { get; set; } // ApplicationName

        public string? Description { get; set; }
    }
}
