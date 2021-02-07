using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Models
{
    public class Province:BaseEntity
    {
        public Province()
        {
            city = new HashSet<City>();
        }
        public string Provinc { get; set; }
        public ICollection<City> city { get; set; }
    }
}
