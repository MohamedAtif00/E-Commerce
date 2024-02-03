namespace E_Commerce.Domain.Model.Review.ValueObject
{
    public class CommentId : Common.ValueObject
    {
        public Guid value { get; set; }

        private CommentId(Guid value)
        {
            this.value = value;
        }

        public static CommentId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}