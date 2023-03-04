using System.Collections.Generic;

namespace FIshing_Club_Mania.Models
{
    public class FishingPlaceViewModelList
    {
        public List<FishingPlaceViewModel> List { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
