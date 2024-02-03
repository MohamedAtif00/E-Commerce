using E_Commerce.Domain.Common;
using E_Commerce.Domain.Model.SubCategory.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.SubCategory
{
    internal class SubCategory : Entity<SubCategoryId>
    {
        public SubCategory(SubCategoryId id) : base(id)
        {
        }

        public string Name { get;private set; }
        public string Description { get; private set; }


        
    }
}
