using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Product.ValueObject
{
    public class Price : Common.Abstract.ValueObject
    {
        public decimal value { get; private set; }
        public Currency currency { get; private set; }

        public Price(decimal value,Currency currency)
        {
            this.value = value;
            this.currency = currency;
        }

        public static Price Create(decimal value,Currency currency)
        {
            return new(value,currency);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
            yield return currency;

        }
    }
}
