namespace AirportRESRfulApi.DAL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class PlaneType : Entity
    {
        [Required, MaxLength(50)]
        public string Model { set; get; }
        [Required]
        public int Seats { set; get; }
        [Required]
        public int Capacity { set; get; }
        [Required]
        public int Range { set; get; }
        [Required]
        public TimeSpan ServiceLife { set; get; }

        public int PlaneId { set; get; }
    }
}