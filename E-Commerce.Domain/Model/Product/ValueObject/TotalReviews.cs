using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Product.ValueObject
{
    public class TotalReviews : Common.Abstract.ValueObject
    {
        public decimal Value { get; private set; }

        public TotalReviews(decimal value)
        {
            Value = value;
        }

        public static TotalReviews Create(decimal value)
        {
            return new(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
