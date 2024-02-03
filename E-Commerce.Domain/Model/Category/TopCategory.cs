using E_Commerce.Domain.Common;
using E_Commerce.Domain.Model.Category.Entity;
using E_Commerce.Domain.Model.Category.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Category
{
    internal class TopCategory : AggregateRoot<TopCategoryId>
    {
        private readonly List<Entity.Category> _categories = new();

        public string Name { get; private set; }
        public DateTime CreationDate { get; init; } = DateTime.UtcNow;

        public IReadOnlyCollection<Entity.Category> Categories { get {  return _categories; } }

        private TopCategory(TopCategoryId id,string Name) : base(id)
        {
        }


        public static TopCategory Create(string Name)
        {
            return new(TopCategoryId.CreateUnique(),Name);
        }


    }
}
