using EShopAPI.Contracts;
using EShopAPI.Models;
using EShopAPI.Context;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;

namespace EShopAPI.Repositories
{
    public class ProvinceRepository : AsyncGenericRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(EShopAPI_DBContext context, IMemoryCache cache) : base(context, cache) { }
    }
}
