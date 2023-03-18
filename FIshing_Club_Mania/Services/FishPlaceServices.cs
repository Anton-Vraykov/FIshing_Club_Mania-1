

namespace FIshing_Club_Mania.Services
{
    using FIshing_Club_Mania.DataAccess;
    using FIshing_Club_Mania.DataModels;
    using System.Collections.Generic;
    using System.Linq;

    public class FishPlaceServices : IFishPlaceServices
    {
        private readonly AppDbContext db;
        private const int Password = 123;
        public FishPlaceServices(AppDbContext db)
        {
            this.db = db;
        }

        
        public void Add(FishingPlaceService fishingPlace)
        {
            if (fishingPlace.Reservation <= System.DateTime.Now)
            {
                return;
            }
            if (fishingPlace.Price < 0)
            {
                return;
            }
            if (fishingPlace.Password != Password)
            {
              return;
            }
            

            this.db.fishingPlace.Add(fishingPlace);
            this.db.SaveChanges();
        }

        public void Delete(int Id,int password)
        {
            if (password!=Password)
            {
                return;
            }
            var deletedFishingPlace = this.db.fishingPlace.FirstOrDefault(db => db.Id == Id);
           
            if (deletedFishingPlace == null) { return; }
            
            
            deletedFishingPlace.IsDeleted = true;
            this.db.SaveChanges();
            
        }

        public FishingPlaceService GetById(int id)
        {
            return this.db.fishingPlace.Where(x => !x.IsDeleted).FirstOrDefault(x => x.Id == id);
        }

        public int GetFishingPlaceCount() => this.db.fishingPlace.Where(x => !x.IsDeleted).Count();


        public List<FishingPlaceService> ShowAllPlace(int skip, int take)
        {
            return this.db.fishingPlace.Where(x => !x.IsDeleted).OrderByDescending(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(FishingPlaceService fishingPlace)
        {

            if (fishingPlace.Reservation <= System.DateTime.Now)
            {
                return;
            }
            if (fishingPlace.Price < 0)
            {
                return;
            }
            if (fishingPlace.Password != Password)
            {
                return;
            }
           else
            {
               fishingPlace.Password = 8657;
            }

            var fishingPlaceToUpdate = this.db.fishingPlace.FirstOrDefault(x => x.Id == fishingPlace.Id);
                if (fishingPlaceToUpdate == null) { return; }


                fishingPlaceToUpdate.Name = fishingPlace.Name;
                fishingPlaceToUpdate.Description = fishingPlace.Description;
                fishingPlaceToUpdate.Location = fishingPlace.Location;
                fishingPlaceToUpdate.PictureURL = fishingPlace.PictureURL;
                fishingPlaceToUpdate.Price = fishingPlace.Price;
                fishingPlaceToUpdate.Password = fishingPlace.Password;

                this.db.SaveChanges();


            
        }
    }
}
