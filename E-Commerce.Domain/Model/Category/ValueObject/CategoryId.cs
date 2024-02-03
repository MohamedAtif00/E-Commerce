using E_Commerce.Domain.Common;

namespace E_Commerce.Domain.Model.Category.ValueObject
{
    internal class CategoryId : Common.ValueObject
    {
        public Guid value { get; set; }

        private CategoryId(Guid value)
        {
            this.value = value;
        }

        public static CategoryId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}