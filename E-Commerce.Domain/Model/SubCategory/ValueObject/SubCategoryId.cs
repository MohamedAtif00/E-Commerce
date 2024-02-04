using E_Commerce.Domain.Model.Product.ValueObject;

namespace E_Commerce.Domain.Model.SubCategory.ValueObject
{
    public class SubCategoryId : Common.Abstract.ValueObject
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

        public static SubCategoryId Create(Guid value)
        {
            return new SubCategoryId(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}