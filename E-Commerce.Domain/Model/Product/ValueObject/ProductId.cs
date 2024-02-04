using E_Commerce.Domain.Model.Category.ValueObject;

namespace E_Commerce.Domain.Model.Product.ValueObject
{
    public class ProductId : Common.Abstract.ValueObject
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

        public static ProductId Create(Guid value)
        {
            return new(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}