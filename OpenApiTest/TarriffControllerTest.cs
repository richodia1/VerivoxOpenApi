using API.Controllers;
using API.Model;
using API.ProductFactory;
using API.Service;
using System;
using System.Collections.Generic;
using Xunit;

namespace OpenApiTest
{
    public class TarriffControllerTest
    {
        private IProductGeneratorService _productGeneratorService;
        private readonly TarriffController _controller;
        private readonly IProductTarrifFactory _productTarrifFactory;

        public TarriffControllerTest()
        {
            _productTarrifFactory = new ProductTarrifFactory();
            _productGeneratorService = new ProductGeneratorService(_productTarrifFactory);
            _controller = new TarriffController(_productGeneratorService);
        }
        [Fact]
        public void Test_Basic_And_Package_Tarriff_ToGet_ProductList_When_Consumption_Is_0()
        {
            // Arrange 
            var consumption = 0;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.NotNull(items);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order

        }
        [Fact]
        public void TTest_Basic_And_Package_Tarriff_ToGet_ProductList_When_Consumption_Is_4000()
        {
            // Arrange 
            var consumption = 4000;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.NotNull(items);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order
           
        }
        [Fact]
        public void Test_Basic_And_Package_Tarriff_ToGet_ProductList_When_Consumption_Is_6000()
        {
            // Arrange 
            var consumption = 6000;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.NotNull(items);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order

        }
        [Fact]
        public void Test_Basic_And_Package_Tarriff_ToGet_ProductList_When_Consumption_Is_4500()
        {
            // Arrange 
            var consumption = 4500;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.NotNull(items);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order

        }
        [Fact]
        public void Test_Basic_And_Package_Tarriff_ToGet_ProductList_When_Consumption_Is_3500()
        {
            // Arrange 
            var consumption = 3500;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.NotNull(items);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order

        }

    }
}
