using PromoCodeManagement.Data.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromoCodeManagement.Data
{
    public interface IPromoRepository
    {
        //void Add<T>(T entity) where T : class;
        //void Delete<T>(T entity) where T : class;
        //Task<bool> SaveChangesAsync();


        // Speakers
       // Task<PromoCode[]> GetSpeakersByMonikerAsync(string moniker);
        Task<PromoCode> GetPromoAsync(string Code);
        Task<PromoCode[]> GetAllPromosAsync();
    }
}
