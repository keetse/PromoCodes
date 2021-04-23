using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PromoCodeManagement.Data.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromoCodeManagement.Data
{
    public class PromoRepository: IPromoRepository
    {
        private readonly PromoCodeContext _context;
        private readonly ILogger<PromoRepository> _logger;

        public PromoRepository(PromoCodeContext context, ILogger<PromoRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<PromoCode[]> GetAllPromosAsync()
        {
            _logger.LogInformation($"Getting Promos");

            var query = _context.PromoCodes;
              

            return await query.ToArrayAsync();
        }


        public async Task<PromoCode> GetPromoAsync(string Code)
        {
            _logger.LogInformation($"Getting promoCode");

            var query = _context.PromoCodes
              .Where(t => t.Code == Code);

            return await query.FirstOrDefaultAsync();
        }
    }
}
