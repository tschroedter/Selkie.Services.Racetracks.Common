using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Common.Dto;
using Selkie.Services.Racetracks.Common.Messages;
using Xunit;

namespace Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    public sealed class RacetracksResponseMessageTests
    {
        [Fact]
        public void Racetracks_ReturnsDefault_WhenCalled()
        {
            // assemble
            // act
            var sut = new RacetracksResponseMessage();

            // assert
            Assert.NotNull(sut.Racetracks);
        }

        [Fact]
        public void Racetracks_ReturnsValue_WhenValueIsSet()
        {
            // assemble
            var expected = new RacetracksDto();

            // act
            var sut = new RacetracksResponseMessage
                      {
                          Racetracks = expected
                      };

            // assert
            Assert.Equal(expected,
                         sut.Racetracks);
        }
    }
}