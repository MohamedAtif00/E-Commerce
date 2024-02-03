using E_Commerce.Domain.Common;
using E_Commerce.Domain.Model.Product.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Product.Entity
{
    internal class ProductImage : Entity<ProductImageId>
    {
        public ProductId _productId;
        public string _imageUrl { get; private set; }
        public string _title { get; private set; }

        public Product product { get; private set; }
        public ProductImage(ProductImageId id, ProductId productId,string imageUrl, string title) : base(id)
        {
            _productId = productId;
            _imageUrl = imageUrl;
            _title = title;
        }

        public static ProductImage Create(ProductId productId,string imageUrl,string title)
        {
            return new(ProductImageId.CreateUnique(),productId,imageUrl,title);
        }

        public void Update(string imageUrl,string title)
        {
            _imageUrl = imageUrl ?? string.Empty;
            _title = title;
        }


    }
}
