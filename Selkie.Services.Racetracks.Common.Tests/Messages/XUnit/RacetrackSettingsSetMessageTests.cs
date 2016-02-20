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
                              IsPortTurnAllowed = true,
                              IsStarboardTurnAllowed = true,
                              TurnRadiusForPort = 100.0,
                              TurnRadiusForStarboard = 200.0
                          };

            return nessage;
        }

        [Fact]
        public void IsPortTurnAllowed_ReturnsValueSet_WhenCalled()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.True(message.IsPortTurnAllowed);
        }

        [Fact]
        public void IsStarboardTurnAllowed_ReturnsValueSet_WhenCalled()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.True(message.IsStarboardTurnAllowed);
        }

        [Fact]
        public void TurnRadiusForPort_ReturnsValueSet_WhenCalled()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.Equal(100.0,
                         message.TurnRadiusForPort);
        }

        [Fact]
        public void TurnRadiusForStarboard_ReturnsValueSet_WhenCalled()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.Equal(200.0,
                         message.TurnRadiusForStarboard);
        }
    }
}