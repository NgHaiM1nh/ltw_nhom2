﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceStore_Nhóm2.Models.ViewModel
{
    public class HomeProductVm
    {
        public string SearchTerm { get; set; }

        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 10;

        public List<Product> FeaturedProduct { get; set; }
        public PagedList.IPagedList<Product> NewProducts { get; set; }
    }
}