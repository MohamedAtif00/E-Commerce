namespace E_Commerce.Domain.Model.SubCategory.ValueObject
{
    public class SubCategoryProductId : Common.Abstract.ValueObject
    {
        public Guid value { get; set; }

        private SubCategoryProductId(Guid value)
        {
            this.value = value;
        }

        public static SubCategoryProductId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public static SubCategoryProductId Create(Guid value)
        {
            return new SubCategoryProductId(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}