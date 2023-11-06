using ECommerceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProject.ViewModel
{
    public class OrderProductVM
    {
        public Order Order { get; set; }

        public List<Products> Products { get; set; }
    }
}
