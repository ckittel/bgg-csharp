using FluentAssertions;
using NUnit.Framework;

namespace BoardGameGeek.Api.Accounts
{
    [TestFixture]
    public class BggClientAccountTests
    {
        [Test]
        public void Test()
        {
            // Arrange
            var client = new BggClient();

            // Act
            //var result = client.GetAccount("v3rt1g0");

            ServerToClientModelMaps.RunMe();
            ServerToClientModelMaps.RunMe();
            ServerToClientModelMaps.RunMe();

            // Assert
            //result.Should().NotBeNull();
        }
    }
}
