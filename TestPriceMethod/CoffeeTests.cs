using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleAppNet60;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoffeeShopConsoleAppNet60.Tests
{
    [TestClass()]
    public class CoffeeTests
    { 

        [TestMethod()]
        [DataRow("Latte", 40, 5)]
        [DataRow("Cortado", 25)]
        [DataRow("B", 20)]
        public void PriceTest(string coffeeType, int expectedPrice, int discount)
        {
            //Arrange 
            //switch bruges til at oprette et instans af en bestemt coffee-subklasse, baseret på værdien af coffeetype 
            Coffee c = coffeeType switch
            {
                "B" => new BlackCoffee(),
                "Cortado" => new Cortado(),
                "Latte" => new Latte(discount)
                
            };

            // Act
            int actualPrice = c.Price();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }


        [TestMethod()]
        [DataRow("Latte", "Weak")]
        [DataRow("Cortado", "Medium")]
        [DataRow("B", "Strong")]
        public void StrengtTest(string coffeeType, string expectedStrenght)
        {
            //Arrange 
            //switch bruges til at oprette et instans af en bestemt coffee-subklasse, baseret på værdien af coffeetype 
            Coffee c = coffeeType switch
            {
                "B" => new BlackCoffee(),
                "Cortado" => new Cortado(),
                "Latte" => new Latte(3)

            };

            // Act
            string actualPrice = c.Strength();

            // Assert
            Assert.AreEqual(expectedStrenght, actualPrice);
        }

        [TestMethod()]
        public void TestDiscount()
        {
            //arrange 

            //Act + Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Latte(7));

        }
    }
}