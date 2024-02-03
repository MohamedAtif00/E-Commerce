using E_Commerce.Domain.Model.Category;
using E_Commerce.Domain.Model.Category.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Common.Interface
{
    internal interface ICategoryRepository:IGenericRepository<TopCategory,TopCategoryId>
    {
    }
}
