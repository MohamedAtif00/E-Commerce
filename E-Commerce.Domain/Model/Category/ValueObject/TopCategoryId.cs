namespace E_Commerce.Domain.Model.Category.ValueObject
{
    internal class TopCategoryId : Common.ValueObject
    {
        public Guid value { get; set; }

        private TopCategoryId(Guid value)
        {
            this.value = value;
        }

        public static TopCategoryId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}