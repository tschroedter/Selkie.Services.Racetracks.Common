using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Core2.Selkie.Services.Racetracks.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class RacetrackSettingsChangedMessageTests
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

        [Test]
        public void IsPortTurnAllowedTest()
        {
            // assemble
            // act
            RacetrackSettingsChangedMessage requestMessage = CreateMessage();

            // assert
            Assert.True(requestMessage.IsPortTurnAllowed);
        }

        [Test]
        public void IsStarboardTurnAllowedTest()
        {
            // assemble
            // act
            RacetrackSettingsChangedMessage requestMessage = CreateMessage();

            // assert
            Assert.True(requestMessage.IsStarboardTurnAllowed);
        }

        [Test]
        public void TurnRadiusForPortTest()
        {
            // assemble
            // act
            RacetrackSettingsChangedMessage requestMessage = CreateMessage();

            // assert
            Assert.AreEqual(100.0,
                         requestMessage.TurnRadiusForPort);
        }

        [Test]
        public void TurnRadiusForStarboardTest()
        {
            // assemble
            // act
            RacetrackSettingsChangedMessage requestMessage = CreateMessage();

            // assert
            Assert.AreEqual(200.0,
                         requestMessage.TurnRadiusForStarboard);
        }
    }
}