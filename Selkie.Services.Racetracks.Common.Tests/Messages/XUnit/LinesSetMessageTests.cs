﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using JetBrains.Annotations;
using Selkie.Services.Common.Dto;
using Selkie.Services.Racetracks.Common.Messages;
using Xunit;

namespace Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    //ncrunch: no coverage start
    [ExcludeFromCodeCoverage]
    public sealed class LinesSetMessageTests
    {
        [NotNull]
        private LinesSetMessage CreateMessage([NotNull] IEnumerable <LineDto> lineDtos)
        {
            var message = new LinesSetMessage
                          {
                              LineDtos = lineDtos.ToArray()
                          };

            return message;
        }

        [Fact]
        public void LineDtosTest()
        {
            // assemble
            LineDto[] expected =
            {
                new LineDto()
            };

            // act
            LinesSetMessage message = CreateMessage(expected);

            // assert
            Assert.Equal(expected,
                         message.LineDtos);
        }
    }
}