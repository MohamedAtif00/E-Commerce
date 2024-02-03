using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Product.ValueObject
{
    internal class TotalReviews : Common.ValueObject
    {
        public decimal Value { get; private set; }

        public TotalReviews(decimal value)
        {
            Value = value;
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
