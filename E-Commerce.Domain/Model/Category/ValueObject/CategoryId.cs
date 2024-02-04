namespace E_Commerce.Domain.Model.Category.ValueObject
{
    public class CategoryId : Common.Abstract.ValueObject
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