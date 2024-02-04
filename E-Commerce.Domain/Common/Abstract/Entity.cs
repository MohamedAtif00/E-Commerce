using E_Commerce.Domain.Common.Interface;
using E_Commerce.Domain.Model.Category.Entity;

namespace E_Commerce.Domain.Common.Abstract
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>>
        where TId : notnull
    {
        public TId Id { get; protected init; }

        protected Entity(TId id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            //return obj is Entity<TId> && Id.Equals(((Entity<TId>)obj).Id);
            if (obj == null || GetType() != obj.GetType())
                return false;

            Category otherCategory = (Category)obj;
            return Id.Equals(otherCategory.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Equals(Entity<TId>? other)
        {
            return Equals((object?)other);
        }

        public static bool operator ==(Entity<TId> left, Entity<TId> right)
        {
            return Equals(right, left);
        }

        public static bool operator !=(Entity<TId> left, Entity<TId> right)
        {
            return !Equals(left, right);
        }

        internal void CheckRule(IBusinessRule rule)
        {
            if (rule.isBroken())
            {
                throw new BusinessRuleValidationException(rule);
            }
        }

    }
}
