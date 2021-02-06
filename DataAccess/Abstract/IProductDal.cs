using Core.DataAccess;
using Entities.Concrete;
using Entities.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Dal - Data Access Layer
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

//code refactoring