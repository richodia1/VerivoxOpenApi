using API.Controllers;
using API.Model;
using API.Service;
using System;
using System.Collections.Generic;
using Xunit;

namespace OpenApiTest
{
    public class TarriffControllerTest
    {
        private IProductGeneratorService productGeneratorService;
        private readonly TarriffController _controller;

        public TarriffControllerTest()
        {
            productGeneratorService = new ProductGeneratorService();
            _controller = new TarriffController(productGeneratorService);
        }
        [Fact]
        public void TestBasicAndPackageTarriffCalculationWithConsumptionAs0()
        {
            // Arrange 
            var consumption = 0;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order

        }
        [Fact]
        public void TestBasicAndPackageTarriffCalculationWithConsumptionAs4000()
        {
            // Arrange 
            var consumption = 4000;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order
           
        }
        [Fact]
        public void TestBasicAndPackageTarriffCalculationWithConsumptionAs6000()
        {
            // Arrange 
            var consumption = 6000;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order

        }
        [Fact]
        public void TestBasicAndPackageTarriffCalculationWithConsumptionAs4500()
        {
            // Arrange 
            var consumption = 4500;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order

        }
        [Fact]
        public void TestBasicAndPackageTarriffCalculationWithConsumptionAs3500()
        {
            // Arrange 
            var consumption = 3500;
            // Act
            var okResult = _controller.GetProducts(consumption);

            // Assert
            var items = Assert.IsType<List<Product>>(okResult);
            Assert.Equal(2, items.Count);
            Assert.NotEqual(items[0].AnnualCost, items[1].AnnualCost);
            Assert.True(items[0].AnnualCost < items[1].AnnualCost);  // always sorted in Acsending order

        }

    }
}
