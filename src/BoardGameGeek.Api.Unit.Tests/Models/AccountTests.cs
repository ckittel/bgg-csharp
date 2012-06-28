using FluentAssertions;
using NUnit.Framework;

namespace BoardGameGeek.Api.Models
{
    [TestFixture]
    public class AccountTests
    {
        [Test]
        public void When_Ctord_Then_PropertyDefaultsAreSet()
        {
            // Act
            var result = new Account();

            // Assert
            result.AvatarUrl.Should().BeNull();
            result.Country.Should().BeNull();
            result.ExternalGamingAccounts.BattlenetAccount.Should().BeNull();
            result.ExternalGamingAccounts.PlayStationNetworkAccount.Should().BeNull();
            result.ExternalGamingAccounts.SteamAccount.Should().BeNull();
            result.ExternalGamingAccounts.WiiAccount.Should().BeNull();
            result.ExternalGamingAccounts.XBoxAccount.Should().BeNull();
            result.FirstName.Should().BeNull();
            result.Id.Should().BeNull();
            result.LastName.Should().BeNull();
            result.State.Should().BeNull();
            result.TraderRating.Should().Be(0);
            result.UserName.Should().BeNull();
            result.WebsiteUrl.Should().BeNull();
            result.YearRegistered.Should().Be(null);
        }
    }
}
