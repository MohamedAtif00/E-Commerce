using E_Commerce.Domain.Common;
using E_Commerce.Domain.Model.Category.ValueObject;
using E_Commerce.Domain.Model.SubCategory.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Category.Entity
{
    internal class Category : Entity<CategoryId>
    {
        public readonly List<SubCategoryId> _subCategoryIds = new();
        public string Name { get;private set; }
        public string Description { get;private set; }  
        public TopCategoryId TopCategoryId { get; set; }

        public IReadOnlyCollection<SubCategoryId> subCategoryIds { get { return _subCategoryIds; } }
        public TopCategory _topCategory { get;private set; }
        // Constructor
        public Category(CategoryId id, string name, string description, TopCategoryId topCategoryId) : base(id)
        {
            Name = name;
            Description = description;
            TopCategoryId = topCategoryId;
        }


        public static Category Create(string name,
                                      string description,
                                      TopCategoryId topCategoryId)
        {
            return new(CategoryId.CreateUnique(),
                       name,
                       description,
                       topCategoryId);
        }

        public void Update(string name,
                           string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public void AddSubCategory(SubCategoryId subCategoryId)
        { 
            this._subCategoryIds.Add(subCategoryId);
        }

        public void removeSubCategory(SubCategoryId subCategoryId)
        {
            _subCategoryIds.Remove(subCategoryId);
        }



    }
}
