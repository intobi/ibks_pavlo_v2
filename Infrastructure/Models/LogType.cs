﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public partial class LogType
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<TicketEventLog> TicketEventLogs { get; set; } =
        new List<TicketEventLog>();
}
