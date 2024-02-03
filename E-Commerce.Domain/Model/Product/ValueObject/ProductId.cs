
using E_Commerce.Domain.Model.Category.ValueObject;

namespace E_Commerce.Domain.Model.Product.ValueObject
{
    internal class ProductId : Common.ValueObject
    {
        public Guid value { get; set; }

        private ProductId(Guid value)
        {
            this.value = value;
        }

        public static ProductId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}