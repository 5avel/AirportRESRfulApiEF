using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportRESRfulApi.DAL
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository<Ticket>
    {
        AirportContext context;
        public TicketRepository(AirportContext context) : base(context)
        {
            this.context = context;
        }


    }
}
