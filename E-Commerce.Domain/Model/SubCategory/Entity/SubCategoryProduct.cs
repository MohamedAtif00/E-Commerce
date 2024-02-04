using E_Commerce.Domain.Common.Abstract;
using E_Commerce.Domain.Model.Product;
using E_Commerce.Domain.Model.Product.ValueObject;
using E_Commerce.Domain.Model.SubCategory.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.SubCategory.Entity
{
    public sealed class SubCategoryProduct : Entity<(ProductId,SubCategoryId)>
    {
        internal ProductId ProductId { get;private set; }
        internal SubCategoryId SubCategoryId { get; private set; }
        public string _name { get; private set; }
        private DateTime _creationDate { get; init; } = DateTime.UtcNow;
        public bool _block { get; private set; } = false;
        public bool _isRemoved { get; private set; } = false;
        public int _vistedNumbers { get; private set; } = 0;


        public SubCategoryProduct((ProductId productId,SubCategoryId subCategoryId) id, string name) : base(id)
        {
            this._name = name;
        }

        public static SubCategoryProduct Create((ProductId productId,SubCategoryId subCategoryId)id,string name)
        {
            return new((id.productId,id.subCategoryId),name);
        }

        public void Update(string name)
        {
            _name = name;
        }

        public void Visited()
        {
            _vistedNumbers++;
        }

        public void SetAsRemoved()
        {
            _isRemoved = true;
        }

    }
}
