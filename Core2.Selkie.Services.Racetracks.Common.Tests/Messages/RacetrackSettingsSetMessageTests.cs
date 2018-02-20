using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Core2.Selkie.Services.Racetracks.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class RacetrackSettingsSetMessageTests
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

        [Test]
        public void IsPortTurnAllowed_ReturnsValueSet_WhenCalled()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.True(message.IsPortTurnAllowed);
        }

        [Test]
        public void IsStarboardTurnAllowed_ReturnsValueSet_WhenCalled()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.True(message.IsStarboardTurnAllowed);
        }

        [Test]
        public void TurnRadiusForPort_ReturnsValueSet_WhenCalled()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.AreEqual(100.0,
                         message.TurnRadiusForPort);
        }

        [Test]
        public void TurnRadiusForStarboard_ReturnsValueSet_WhenCalled()
        {
            // assemble
            // act
            RacetrackSettingsSetMessage message = CreateMessage();

            // assert
            Assert.AreEqual(200.0,
                         message.TurnRadiusForStarboard);
        }
    }
}