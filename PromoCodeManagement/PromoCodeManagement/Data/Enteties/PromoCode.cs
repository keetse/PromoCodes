using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PromoCodeManagement.Data.Enteties
{
    public class PromoCode
    {
        [Key]
        public int PromoId { get; set; }
        public string Code { get; set; }
        
    }
}
