﻿using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchMvc.WebUi.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService )
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetProducts();

            return View(products);
        }
    }
}
