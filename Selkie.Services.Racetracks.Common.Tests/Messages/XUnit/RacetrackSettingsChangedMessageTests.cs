using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Selkie.Services.Racetracks.Common.Messages;
using Xunit;

namespace Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    //ncrunch: no coverage start
    [ExcludeFromCodeCoverage]
    public sealed class RacetrackSettingsChangedMessageTests
    {
        [NotNull]
        private RacetrackSettingsChangedMessage CreateMessage()
        {
            var nessage = new RacetrackSettingsChangedMessage
                          {
                              TurnRadiusForPort = 100.0,
                              TurnRadiusForStarboard = 200.0,
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
            RacetrackSettingsChangedMessage requestMessage = CreateMessage();

            // assert
            Assert.True(requestMessage.IsPortTurnAllowed);
        }

        [Fact]
        public void IsStarboardTurnAllowedTest()
        {
            // assemble
            // act
            RacetrackSettingsChangedMessage requestMessage = CreateMessage();

            // assert
            Assert.True(requestMessage.IsStarboardTurnAllowed);
        }

        [Fact]
        public void TurnRadiusForPortTest()
        {
            // assemble
            // act
            RacetrackSettingsChangedMessage requestMessage = CreateMessage();

            // assert
            Assert.Equal(100.0,
                         requestMessage.TurnRadiusForPort);
        }

        [Fact]
        public void TurnRadiusForStarboardTest()
        {
            // assemble
            // act
            RacetrackSettingsChangedMessage requestMessage = CreateMessage();

            // assert
            Assert.Equal(200.0,
                         requestMessage.TurnRadiusForStarboard);
        }
    }
}