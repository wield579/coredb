using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETCOREWEB.Models;
using NETCOREWEB.Services;

namespace NETCOREWEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            List<Product> products = _productService.GetProductList();
            return View(products);
        }
    }
}
