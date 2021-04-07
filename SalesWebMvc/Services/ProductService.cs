﻿using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class ProductService
    {
        private readonly SalesWebMvcContext _context;

        public ProductService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Products> FindAll()
        {
            return _context.Products.ToList();
        }

        public void Insert(Products obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
