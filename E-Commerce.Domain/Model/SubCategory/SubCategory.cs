using E_Commerce.Domain.Common.Abstract;
using E_Commerce.Domain.Model.Product.ValueObject;
using E_Commerce.Domain.Model.SubCategory.Entity;
using E_Commerce.Domain.Model.SubCategory.Rule;
using E_Commerce.Domain.Model.SubCategory.ValueObject;


namespace E_Commerce.Domain.Model.SubCategory
{
    public sealed class SubCategory : Entity<SubCategoryId>
    {
        public readonly List<SubCategoryProduct> _products = new();
        public readonly List<SubCategory> _childsSubCategories = new();
        public string _name { get;private set; }
        public string _description { get; private set; }
        public SubCategoryId _parentSubCategoryId { get; private set; }

        public SubCategory _parentSubCategory { get; private set; }
        private IReadOnlyCollection<SubCategoryProduct> products { get { return _products; } }
        private IReadOnlyCollection<SubCategory> childsSubCategories { get { return _childsSubCategories; } }


        public SubCategory(SubCategoryId id,string name,string description) : base(id)
        {
            _name = name;
            _description = description;
        }

        public static SubCategory Create(string name,string description)
        {
            return new(SubCategoryId.CreateUnique(),name,description);
        }

        public void Update(string name,string description)
        {
            CheckRule(new NameCannotBeEmpityRule(name));
            CheckRule(new DescriptionCanNotBeNullOrEmpity(description));
            _name = name;
            _description = description;
        }

        public void AddProduct(ProductId productId)
        {
            var product = SubCategoryProduct.Create((productId,Id),_name);
            _products.Add(product);
        }

        public void RemoveProduct(ProductId productId)
        {
            var product = products.Where(x => x.Id.Item1 == productId).Single();
            product.SetAsRemoved();
        }

        
    }
}
