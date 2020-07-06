using NETCOREWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCOREWEB.Services
{
    public interface IProductService
    {
        List<Product> GetProductList();
    }
}
