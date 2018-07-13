using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.DAL
{
    public class AirportContext : IAirportContext
    {
        public AirportContext()
        {
            CreateSeedsData();
        }

        public List<Flight> Flights { private set; get; }
        public List<Departure> Departures { private set; get; }
        public List<Ticket> Tickets { private set; get; }
        public List<Crew>  Crews { private set; get; }
        public List<Pilot> Pilots { private set; get; }
        public List<Stewardess> Stewardesses { private set; get; }
        public List<PlaneType> PlaneTyps { private set; get; }
        public List<Plane> Planes { private set; get; }

        private void CreateSeedsData()
        {
            Tickets = new List<Ticket>();
            Pilots = new List<Pilot>
            {
                new Pilot
                {
                    Id = 1,
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Birthday = new DateTime(1987, 1, 24, 0, 0, 0),
                    CrewId = 1,
                    Experience = 8

                },
                new Pilot
                {
                    Id = 2,
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Birthday = new DateTime(1977, 1, 24, 0, 0, 0),
                    CrewId = 2,
                    Experience = 3
                }
            };

            Stewardesses = new List<Stewardess>
            {
                new Stewardess
                {
                    Id = 1,
                    FirstName = "Janna",
                    LastName = "Ivanova",
                    Birthday = new DateTime(1997, 1, 24, 0, 0, 0),
                    CrewId = 1,

                },
                new Stewardess
                {
                    Id = 2,
                    FirstName = "Petra",
                    LastName = "Petrova",
                    Birthday = new DateTime(1977, 1, 24, 0, 0, 0),
                    CrewId = 2,
                },
                new Stewardess
                {
                    Id = 3,
                    FirstName = "Anna",
                    LastName = "Petrova",
                    Birthday = new DateTime(1997, 1, 24, 0, 0, 0),
                    CrewId = 2,
                },
                new Stewardess
                {
                    Id = 4,
                    FirstName = "Irina",
                    LastName = "Petrova",
                    Birthday = new DateTime(1997, 1, 24, 0, 0, 0),
                    CrewId = 2,
                }
            };

            Crews = new List<Crew>
            {
                new Crew
                {
                    Id = 1,
                    Pilot = Pilots.FirstOrDefault(x => x.Id == 1),
                    Stewardesses = Stewardesses.Where(x => x.Id <= 2).ToList(),
                    DepartureId = 1
                },
                new Crew
                {
                    Id = 2,
                    Pilot = Pilots.FirstOrDefault(x => x.Id == 2),
                    Stewardesses = Stewardesses.Where(x => x.Id == 3 & x.Id == 4).ToList(),
                    DepartureId = 2

                }
            };

            PlaneTyps = new List<PlaneType>
            {
                new PlaneType
                {
                    Id = 1,
                    Model = "Ту-134",
                    Seats = 80,
                    Capacity = 47000,
                    Range = 2800,
                    ServiceLife = new TimeSpan(200, 0, 0, 0)
                },
                new PlaneType
                {
                    Id = 2,
                    Model = "A310",
                    Seats = 183,
                    Capacity = 164000,
                    Range = 5500,
                    ServiceLife = new TimeSpan(300, 0, 0, 0)
                }
            };

            Planes = new List<Plane>
            {
                new Plane
                {
                    Id = 1,
                    DepartureId = 1,
                    Name = "T13",
                    PlaneTypeID = 1,
                    PlaneType = PlaneTyps.FirstOrDefault(x => x.Id == 1)
                },
                new Plane
                {
                    Id = 2,
                    DepartureId = 2,
                    Name = "A4",
                    PlaneTypeID = 2,
                    PlaneType = PlaneTyps.FirstOrDefault(x => x.Id == 2)
                }
            };

            Departures = new List<Departure>
            {
                new Departure
                {
                    Id = 1,
                    Flightid = 1,
                    FlightNumber = "QW11",
                    DepartureTime = DateTime.Now,
                    Plane = Planes.FirstOrDefault(x => x.Id == 1),
                    Crew = Crews.FirstOrDefault(x => x.Id == 1)

                },
                new Departure
                {
                    Id = 2,
                    Flightid = 2,
                    FlightNumber = "QW13",
                    DepartureTime = DateTime.Now,
                     Plane = Planes.FirstOrDefault(x => x.Id == 2),
                    Crew = Crews.FirstOrDefault(x => x.Id == 2)
                }
            };

            Flights = new List<Flight>
            {
                new Flight
                {
                    Id = 1,
                    FlightNumber = "QW11",
                    DeparturePoint = "London",
                    DepartureTime = Convert.ToDateTime("2018-07-13T08:22:56.6404304+03:00"),
                    DestinationPoint = "Ukraine",
                    ArrivalTime = Convert.ToDateTime("2018-07-13T08:22:56.6404304+03:00") + TimeSpan.FromHours(5),
                    Tickets = CreateTickets(80, 1, "QW11"),
                    Departure = Departures.FirstOrDefault(x => x.Id == 1)

                },
                new Flight
                {
                    Id = 2,
                    FlightNumber = "QW13",
                    DeparturePoint = "Ukraine",
                    DepartureTime = DateTime.Now,
                    DestinationPoint = "London",
                    ArrivalTime = DateTime.Now + TimeSpan.FromHours(5),
                    Tickets = CreateTickets(183, 2, "QW13"),
                    Departure = Departures.FirstOrDefault(x => x.Id == 2)

                }
            };
        }

        private List<Ticket> CreateTickets(int planeSids, int flightId, string flightNumber)
        {
            List<Ticket> tickets = new List<Ticket>();
            int startID = 0;
            if (Tickets.Count > 0)
            {
                startID = Tickets.Last().Id;
            }
            for(int i = 1; i <= planeSids; i++)
            {
                tickets.Add(
                    new Ticket
                    {
                        Id = ++startID,
                        FlightId = flightId,
                        FlightNumber = flightNumber,
                        IsSold = false,
                        PlaseNumber = tickets.Count + 1,
                        Price = 200
                    });
            }

            Tickets.AddRange(tickets);
            return tickets;
        }



    }
}
