using E_Commerce.Domain.Model.Category;
using E_Commerce.Domain.Model.Category.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace Domain.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Create_TopCategory_Success()
        {
            // Arrange
            string categoryName = "Example Category";

            // Act
            TopCategory topCategory = TopCategory.Create(categoryName);

            // Assert
            Assert.IsNotNull(topCategory);
            Assert.AreEqual(categoryName, topCategory.Name);
            Assert.IsTrue(topCategory.CreationDate <= DateTime.UtcNow);
        }

        [TestMethod]
        public void Categories_Property_Returns_EmptyList_ByDefault()
        {
            // Arrange
            TopCategory topCategory = TopCategory.Create("Example TopCategory");

            // Act
            IReadOnlyCollection<Category> categories = topCategory.Categories;

            // Assert
            Assert.IsNotNull(categories);
            Assert.AreEqual(0, categories.Count);
        }

        [TestMethod]
        public void AddCategory_ToTopCategory_Success()
        {
            // Arrange
            TopCategory topCategory = TopCategory.Create("Example TopCategory");
            Category category = Category.Create("Example Category","description",topCategory.Id);

            // Act
            topCategory.AddCategory(category);

            // Assert
            Assert.AreEqual(1, topCategory.Categories.Count);
            Logger.LogMessage($"{category.Id}");
            Assert.IsTrue(topCategory.Categories.Contains(category));
        }

    }
}