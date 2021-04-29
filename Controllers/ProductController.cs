using CoreBackend.Api.Dtos;
using CoreBackend.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBackend.Api.Controllers
{
    [Route("api/[controller]")]

    public class ProductController : Controller
    {
        [HttpGet]
        public JsonResult GetProducts()
        {
            return new JsonResult(ProductService.Current.Products);
            //return new JsonResult(new List<Product>
            //{
            //    new Product
            //    {
            //        Id = 1,
            //        Name = "牛奶",
            //        Price = 2.5f
            //    },
            //    new Product
            //    {
            //        Id = 2,
            //        Name = "面包",
            //        Price = 4.5f
            //    }
            //});
        }


        [Route("{id}")]
        public JsonResult GetProduct(int id)
        {
            return new JsonResult(ProductService.Current.Products.SingleOrDefault(x => x.Id == id));
        }

    }
}
