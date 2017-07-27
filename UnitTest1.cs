using System;
using NameParser.App;
using Xunit;

namespace NameParser.Tests
{
    public class WhenParsingNameInformation
    {
        [Fact]
        public void OneNameIsEntered()
        {
           //Arrange
            var name = "Z";
            var nameParser = new Parser();
           //Act
            var result = nameParser.ParseName(name);
           //Assert
           Assert.Equal(result.FirstName, "Z");
        }

        [Fact]
        public void TwoNamesAreEnteredFirstAndLastNameArePopulated()
        {
            //Arrange
            var name = "Steve Jones";
            var nameParser = new Parser();
            //Act
            var result = nameParser.ParseName(name);
            //Assert
            Assert.Equal(result.FirstName, "Steve");
            Assert.Equal(result.LastName, "Jones");
        }

        [Fact]
        public void TwoNamesAreEnteredFirstAndLastNameArePopulated()
        {
            //Arrange
            var name = "Steve Jones";
            var nameParser = new Parser();
            //Act
            var result = nameParser.ParseName(name);
            //Assert
            Assert.Equal(result.FirstName, "Steve");
            Assert.Equal(result.LastName, "Jones");
        }


    }
}
