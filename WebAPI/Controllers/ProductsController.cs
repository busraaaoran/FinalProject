using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //Attribute(class ile ilgili bilgi verme ve imzalama yöntemi)
    public class ProductsController : ControllerBase
    {
        //Loosely coupled (gevşek bağımlılık)
        //IoC Container (inversion of control)
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //dependency chain (bağımlılık zinciri var aşağı ilk satırda)
            
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
