using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Selkie.Services.Racetracks.Common.Messages;
using Xunit;

namespace Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    //ncrunch: no coverage start
    [ExcludeFromCodeCoverage]
    public sealed class RacetrackSettingsSetMessageTests
    {
        [NotNull]
        private RacetrackSettingsSetMessage CreateMessage()
        {
            var nessage = new RacetrackSettingsSetMessage
                          {
                              TurnRadiusInMetres = 100.0,
                              IsPortTurnAllowed = true,
                              IsStarboardTurnAllowed = true
                          };

            return nessage;
        }

        [Fact]
        public void IsPortTurnAllowedTest()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.True(message.IsPortTurnAllowed);
        }

        [Fact]
        public void IsStarboardTurnAllowedTest()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.True(message.IsStarboardTurnAllowed);
        }

        [Fact]
        public void TurnRadiusTest()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.Equal(100.0,
                         message.TurnRadiusInMetres);
        }
    }
}