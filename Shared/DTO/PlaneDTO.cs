namespace AirportRESRfulApi.Shared.DTO
{
    using System;
    public class PlaneDto : BaseDto
    {
        public int DepartureId { get; set; }
        public string Name { set; get; }
        public int PlaneTypeID { set; get; }
        public DateTime ReleaseDate { set; get; }
    }
}
