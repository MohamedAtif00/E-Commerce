namespace E_Commerce.Domain.Model.Product.ValueObject
{
    internal class ProductImageId: Common.ValueObject
    {
        public Guid value { get; set; }

        private ProductImageId(Guid value)
        {
            this.value = value;
        }

        public static ProductImageId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}