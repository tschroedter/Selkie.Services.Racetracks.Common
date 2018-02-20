using System;
using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Services.Common.Dto;
using Core2.Selkie.Services.Racetracks.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class CostMatrixCalculateMessageTests
    {
        private const double Tolerance = 0.00001;

        [Test]
        public void IsPortTurnAllowed_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.True(sut.IsPortTurnAllowed);
        }

        [Test]
        public void IsStarboardTurnAllowed_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.True(sut.IsStarboardTurnAllowed);
        }

        [Test]
        public void LineDtos_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.AreEqual(2,
                         sut.LineDtos.Length);
        }

        [Test]
        public void TurnRadiusForPort_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.True(Math.Abs(100.0 - sut.TurnRadiusForPort) < Tolerance);
        }

        [Test]
        public void TurnRadiusForStarboard_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.True(Math.Abs(200.0 - sut.TurnRadiusForStarboard) < Tolerance);
        }

        [Test]
        public void CostMatrixCalculateMessageTest()
        {
            // assemble
            // act
            var message = new CostMatrixCalculateMessage();

            // assert
            Assert.NotNull(message);
        }

        private static CostMatrixCalculateMessage CreateSut()
        {
            return new CostMatrixCalculateMessage
                   {
                       IsPortTurnAllowed = true,
                       IsStarboardTurnAllowed = true,
                       LineDtos = new[]
                                  {
                                      new LineDto(),
                                      new LineDto()
                                  },
                       TurnRadiusForPort = 100.0,
                       TurnRadiusForStarboard = 200
                   };
        }
    }
}