using Data.DTOs;
using Data.Entities;
using Data.Services;
using Moq;
using ONIS.Business.Services;

namespace ProductCatalogTest;

public class ProductsTest
{
    [Fact]
    public async Task GetProducts_ShouldReturnProducts()
    {
        // Arrange
        var products = new List<ProductDTO>
        {
            new ProductDTO { Name = "Product 1", Price = 10.99m },
            new ProductDTO { Name = "Product 2", Price = 20.99m },
            new ProductDTO { Name = "Product 3", Price = 30.99m }
        };

        var mockProductRepository = new Mock<IProductCatalogRepository>();
        mockProductRepository.Setup(x => x.GetProductsAsync())
                             .ReturnsAsync(products);

        var productService = new ProductService(mockProductRepository.Object);

        // Act
        var result = await productService.GetProducts();

        // Assert
        Assert.Equal(products.Count, result.Count());
        Assert.Equal(products[0].Name, result.First().Name);
        Assert.Equal(products[1].Price, result.Skip(1).First().Price);
        Assert.Equal(products[2].Name, result.Last().Name);
    }
   

}