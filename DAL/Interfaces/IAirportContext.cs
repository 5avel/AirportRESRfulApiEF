using AirportRESRfulApi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportRESRfulApi.DAL.Interfaces
{
    public interface IAirportContext
    {
        List<Flight> Flights { get; }
        List<Departure> Departures { get; }
        List<Ticket> Tickets { get; }
        List<Crew> Crews { get; }
        List<Pilot> Pilots {  get; }
        List<Stewardess> Stewardesses { get; }
        List<PlaneType> PlaneTyps { get; }
        List<Plane> Planes { get; }

    }
}
