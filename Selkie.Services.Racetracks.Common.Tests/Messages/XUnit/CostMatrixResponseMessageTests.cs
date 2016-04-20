﻿using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Selkie.Services.Racetracks.Common.Messages;
using Xunit;

namespace Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    //ncrunch: no coverage start
    [ExcludeFromCodeCoverage]
    public sealed class CostMatrixResponseMessageTests
    {
        [NotNull]
        private CostMatrixResponseMessage CreateMessage([NotNull] double[][] matrix)
        {
            var message = new CostMatrixResponseMessage
                          {
                              Matrix = matrix
                          };

            return message;
        }

        [Fact]
        public void IsPortTurnAllowedTest()
        {
            // assemble
            double[][] expected =
            {
                new[]
                {
                    0.0,
                    1.0
                },
                new[]
                {
                    2.0,
                    3.0
                }
            };

            // act
            CostMatrixResponseMessage message = CreateMessage(expected);

            // assert
            Assert.Equal(expected,
                         message.Matrix);
        }
    }
}