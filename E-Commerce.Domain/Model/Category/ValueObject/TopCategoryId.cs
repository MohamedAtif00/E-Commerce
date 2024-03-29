﻿namespace E_Commerce.Domain.Model.Category.ValueObject
{
    public class TopCategoryId : Common.Abstract.ValueObject
    {
        public Guid Value { get;private set; }

        private TopCategoryId(Guid value)
        {
            this.Value = value;
        }

        public static TopCategoryId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public static TopCategoryId Create(Guid value)
        {
            return new(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}