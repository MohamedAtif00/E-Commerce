using E_Commerce.Domain.Model.Review.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Product.ValueObject
{
    public class Currency :Common.Abstract.ValueObject
    {
        public static Currency ZeroStar => new Currency("usd");
        public static Currency HalfStar => new Currency("euro");
        


        public string Value { get; }
        private Currency(string value)
        {

            Value = value;

        }


        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
