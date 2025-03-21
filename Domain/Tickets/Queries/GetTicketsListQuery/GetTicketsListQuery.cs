﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Domain.Tickets.Queries.GetTicketsListQuery
{
    public record GetTicketsListQuery() : IRequest<List<TicketForListPageDto>>;
}
