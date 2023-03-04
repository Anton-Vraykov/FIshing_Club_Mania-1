
namespace FIshing_Club_Mania.Models
{
    using System;
    

    public class FishingPlaceViewModel
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureURL { get; set; }
        public string Location { get; set; }
        public DateTime Reservation { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Password { get; set; }
    }
}
