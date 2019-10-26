﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Vic.SportsStore.Domain.Entities
{
    public class Product
    {
            [HiddenInput(DisplayValue = false)]
            public int ProductId { get; set; }
            public string Name { get; set; }
            [DataType(DataType.MultilineText)]
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
    }
}

