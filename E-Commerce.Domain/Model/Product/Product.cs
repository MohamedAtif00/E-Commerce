using E_Commerce.Domain.Common;
using E_Commerce.Domain.Model.Product.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Product
{
    internal class Product : AggregateRoot<ProductId>
    {

        public string _name { get; private set; }
        public string _description { get; private set; }
        public Price _price { get; private set; }


        public TotalReviews _totalReviews { get; private set; }
        public Product(ProductId id,
                       string name,
                       string description,
                       Price price) : base(id)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public static Product Create(string name,string description,Price price)
        {
            return new(ProductId.CreateUnique(),name,description,price);
        }

        public void Update(string name,string description)
        { 
            _name = name;
            _description = description;
        }

        public void SetTotalReviews(decimal Value)
        {
            _totalReviews = new TotalReviews(Value);
        }

        public void SetPrice(decimal value,Currency currency)
        {
            
            this._price = new Price(value,currency);
        }



    }
}
