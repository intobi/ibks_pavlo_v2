﻿using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class TicketType
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
