using System;
using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Common.Dto;
using Selkie.Services.Racetracks.Common.Messages;
using Xunit;

namespace Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    //ncrunch: no coverage start

    //ncrunch: no coverage start
    [ExcludeFromCodeCoverage]
    public sealed class CostMatrixCalculateMessageTests
    {
        private const double Tolerance = 0.00001;

        [Fact]
        public void IsPortTurnAllowed_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.True(sut.IsPortTurnAllowed);
        }

        [Fact]
        public void IsStarboardTurnAllowed_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.True(sut.IsStarboardTurnAllowed);
        }

        [Fact]
        public void LineDtos_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.Equal(2,
                         sut.LineDtos.Length);
        }

        [Fact]
        public void TurnRadiusForPort_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.True(Math.Abs(100.0 - sut.TurnRadiusForPort) < Tolerance);
        }

        [Fact]
        public void TurnRadiusForStarboard_ReturnsValue_WhenCalled()
        {
            // assemble
            // act
            CostMatrixCalculateMessage sut = CreateSut();

            // assert
            Assert.True(Math.Abs(200.0 - sut.TurnRadiusForStarboard) < Tolerance);
        }

        [Fact]
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