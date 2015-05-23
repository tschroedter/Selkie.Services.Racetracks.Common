using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Racetracks.Common.Messages;
using Xunit;

namespace Selkie.Services.Racetracks.Common.Tests.Messages.XUnit
{
    //ncrunch: no coverage start
    [ExcludeFromCodeCoverage]
    public sealed class CostMatrixCalculateMessageTests
    {
        [Fact]
        public void CostMatrixCalculateMessageTest()
        {
            // assemble
            // act
            var message = new CostMatrixCalculateMessage();

            // assert
            Assert.NotNull(message);
        }
    }
}