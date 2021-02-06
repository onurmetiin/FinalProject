using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.NewFolder
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string UnitsInStock { get; set; }
    }
}
