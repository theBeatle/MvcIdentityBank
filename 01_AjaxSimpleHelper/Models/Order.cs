﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01_AjaxSimpleHelper.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Customer { get; set; }
    }
}