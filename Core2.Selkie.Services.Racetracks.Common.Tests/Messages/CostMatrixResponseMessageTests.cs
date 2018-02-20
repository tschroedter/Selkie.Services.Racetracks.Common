using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Core2.Selkie.Services.Racetracks.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class CostMatrixResponseMessageTests
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
            CostMatrixResponseMessage message = CreateMessage(expected);

            // assert
            Assert.AreEqual(expected,
                         message.Matrix);
        }
    }
}