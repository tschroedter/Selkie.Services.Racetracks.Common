using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Selkie.Services.Racetracks.Common.Messages;
using Xunit;

namespace Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    //ncrunch: no coverage start
    [ExcludeFromCodeCoverage]
    public sealed class CostMatrixChangedMessageTests
    {
        [NotNull]
        private CostMatrixChangedMessage CreateMessage([NotNull] double[][] matrix)
        {
            var message = new CostMatrixChangedMessage
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
            CostMatrixChangedMessage message = CreateMessage(expected);

            // assert
            Assert.Equal(expected,
                         message.Matrix);
        }
    }
}