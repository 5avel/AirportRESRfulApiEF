namespace AirportRESRfulApi.DAL.Models
{
    using System;
    public class Stewardess : Entity
    {
        public int CrewId { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}