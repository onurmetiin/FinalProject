using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categroyDal;

        public CategoryManager(ICategoryDal categroyDal)
        {
            _categroyDal = categroyDal;
        }

        public List<Category> GetAll()
        {
            return _categroyDal.GetAll();
        }
        //select * from Categories where CategoryId = 3
        public Category GetById(int categoryId)
        {
            return _categroyDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
