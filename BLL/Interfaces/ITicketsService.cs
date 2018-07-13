using AirportRESRfulApi.Shared.DTO;
using System;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Interfaces
{
    public interface ITicketsService
    {
        IEnumerable<TicketDto> Get();
        TicketDto GetById(int id);
        IEnumerable<TicketDto> GetNotSoldSByFlightIdAndDate(string flightNumber, DateTime flightDate);
        TicketDto BayById(int id);
        TicketDto ReturnById(int id);
        TicketDto Make(TicketDto entity);
        IEnumerable<TicketDto> Make(IEnumerable<TicketDto> entitys);
        TicketDto Update(TicketDto entity);
        bool Delete(int id);
    }
}
