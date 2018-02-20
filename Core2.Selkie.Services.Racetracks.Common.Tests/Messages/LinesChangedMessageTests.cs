using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using JetBrains.Annotations;
using Core2.Selkie.Services.Common.Dto;
using Core2.Selkie.Services.Racetracks.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class LinesChangedMessageTests
    {
        [NotNull]
        private LinesChangedMessage CreateMessage([NotNull] IEnumerable <LineDto> lineDtos)
        {
            var message = new LinesChangedMessage
                          {
                              LineDtos = lineDtos.ToArray()
                          };

            return message;
        }

        [Test]
        public void LineDtosTest()
        {
            // assemble
            LineDto[] expected =
            {
                new LineDto()
            };

            // act
            LinesChangedMessage message = CreateMessage(expected);

            // assert
            Assert.AreEqual(expected,
                         message.LineDtos);
        }
    }
}