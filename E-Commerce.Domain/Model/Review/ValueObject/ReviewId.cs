using E_Commerce.Domain.Model.Product.ValueObject;

namespace E_Commerce.Domain.Model.Review.ValueObject
{
    public sealed class ReviewId: Common.Abstract.ValueObject
    {
        public Guid value { get; set; }

        private ReviewId(Guid value)
        {
            this.value = value;
        }

        public static ReviewId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}