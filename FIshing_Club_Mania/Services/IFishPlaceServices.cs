using FIshing_Club_Mania.DataModels;
using System.Collections.Generic;

namespace FIshing_Club_Mania.Services
{
    public interface IFishPlaceServices
    {
        List<FishingPlaceService> ShowAllPlace(int skip, int take);
        int GetFishingPlaceCount();
        void Add(FishingPlaceService fishingPlace);
        FishingPlaceService GetById(int id);
        void Update(FishingPlaceService fishingPlace);
        void Delete(int Id,int password);
        
        
    }
}
