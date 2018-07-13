namespace AirportRESRfulApi.DAL.Models
{
    using System;
    public class Plane : Entity
    {
        public int DepartureId { get; set; }
        public string Name { set; get; }
        public int PlaneTypeID { set; get; }
        public PlaneType PlaneType { set; get; }
        public DateTime ReleaseDate { set; get; }
    }
}
