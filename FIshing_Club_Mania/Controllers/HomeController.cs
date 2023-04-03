using FIshing_Club_Mania.DataModels;
using FIshing_Club_Mania.Models;
using FIshing_Club_Mania.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;


namespace FIshing_Club_Mania.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFishPlaceServices fishPlaceServices;

        public HomeController(IFishPlaceServices fishPlaceServices)
        {
            this.fishPlaceServices = fishPlaceServices;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Fish()
        {
            
            return View();
        }
        public IActionResult FishingClubMania()
        {

            return View();
        }

        public IActionResult Privacy(int currentPage=1)
        {
            var skip=(currentPage - 1)*3;
            var take = 3;
            var totalFishingPlaceCount = this.fishPlaceServices.GetFishingPlaceCount();

            var fishingPlaces = this.fishPlaceServices.ShowAllPlace(skip,take);
            var totalPage = totalFishingPlaceCount / 3;
            var totalPages = totalFishingPlaceCount % 3;
            if (totalPages > 0)
            {
                totalPage++;
            }
            var Model = new FishingPlaceViewModelList
            {
                List = GetFishingPlacesViewModel(fishingPlaces),
                CurrentPage=currentPage,
                TotalPages=totalPage,
            };
            return View (Model);
        }
        public IActionResult EditFishingPlace(FishingPlaceViewModel fishingPlace)
        {
            this.fishPlaceServices.Update(GetFishingPlaceDataModel(fishingPlace));
            return Redirect("Privacy");
        }
        public IActionResult FishingPlaceDetails(int fishingPlaceId)
        {
            var fishingPlaceDataModel = this.fishPlaceServices.GetById(fishingPlaceId);
            return View(GetFishingPlaceViewModel(fishingPlaceDataModel));
        }
        [HttpGet]
        public IActionResult AddFishingPlace()
        {

            return View();
        }
        public IActionResult Pictures()
        {
            return View();
        }
        public IActionResult TheChalenge()
        {
            return View();
        }
        public IActionResult Delete(int fishingPlaceId,int password)
        {
            this.fishPlaceServices.Delete(fishingPlaceId,password);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddFishingPlace(FishingPlaceViewModel fishingPlace)
        {
            this.fishPlaceServices.Add(GetFishingPlaceDataModel(fishingPlace));
            return RedirectToAction("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private FishingPlaceService GetFishingPlaceDataModel(FishingPlaceViewModel fishingPlace)
        {
            return new FishingPlaceService
            {
                Id = fishingPlace.Id,
                Name = fishingPlace.Name,
                PictureURL = fishingPlace.PictureURL,
                Location = fishingPlace.Location,
                Reservation = fishingPlace.Reservation,
                Price = fishingPlace.Price,
                Description = fishingPlace.Description,
               Password = fishingPlace.Password,
            };
        }
        private FishingPlaceViewModel GetFishingPlaceViewModel(FishingPlaceService f)
        {
            return new FishingPlaceViewModel
            {
                Id = f.Id,
                Name = f.Name,
                PictureURL = f.PictureURL,
                Location = f.Location,
                Reservation = f.Reservation,
                Description = f.Description,
                Price = f.Price,
               Password = f.Password,

            };
        }

        private List<FishingPlaceViewModel> GetFishingPlacesViewModel(List<FishingPlaceService> source)
        {
            var fishingPlaces = new List<FishingPlaceViewModel>();
            

            foreach (var f in source)
            {
                fishingPlaces.Add(GetFishingPlaceViewModel(f));
            }

            return fishingPlaces;
        }
    }
}
