﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShopBlazor.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Product> Products { get; set; }
    }
}