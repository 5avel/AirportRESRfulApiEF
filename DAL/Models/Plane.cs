namespace AirportRESRfulApi.DAL.Models
{
    using System;
    public class Plane : Entity
    {
        public string Name { set; get; }
        public DateTime ReleaseDate { set; get; }


        public int DepartureId { get; set; }
        public Departure Departure { get; set; }

        public PlaneType PlaneType { set; get; }
    }
}
