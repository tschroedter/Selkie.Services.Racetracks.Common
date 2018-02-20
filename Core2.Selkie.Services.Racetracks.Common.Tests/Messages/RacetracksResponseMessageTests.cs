using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Services.Common.Dto;
using Core2.Selkie.Services.Racetracks.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class RacetracksResponseMessageTests
    {
        [Test]
        public void Racetracks_ReturnsDefault_WhenCalled()
        {
            // assemble
            // act
            var sut = new RacetracksResponseMessage();

            // assert
            Assert.NotNull(sut.Racetracks);
        }

        [Test]
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
            Assert.AreEqual(expected,
                         sut.Racetracks);
        }
    }
}