using E_Commerce.Domain.Model.Product.ValueObject;

namespace E_Commerce.Domain.Model.SubCategory.ValueObject
{
    internal class SubCategoryId : Common.ValueObject
    {
        public Guid value { get; set; }

        private SubCategoryId(Guid value)
        {
            this.value = value;
        }

        public static SubCategoryId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}