using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.992219,-86.841402,Taco Bell Ardmore...", -86.841402)]
        [InlineData("33.145076,-86.749777,Taco Bell Caler...", -86.749777)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoPInstance = new TacoParser();
            //Act
            var actual = tacoPInstance.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);  
        }

        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.992219,-86.841402,Taco Bell Ardmore...", 34.992219)]
        [InlineData("33.145076,-86.749777,Taco Bell Caler...", 33.145076)]
        public void ShouldParseLattitude(string line, double expected)
        {
            //Arrange
            var tacoPInstance = new TacoParser();

            //Act 
            var actual = tacoPInstance.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }



    }
}
