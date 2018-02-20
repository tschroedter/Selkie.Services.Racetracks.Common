using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Core2.Selkie.Services.Racetracks.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class CostMatrixChangedMessageTests
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

        [Test]
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
            Assert.AreEqual(expected,
                         message.Matrix);
        }
    }
}