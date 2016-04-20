using JetBrains.Annotations;

namespace Selkie.Services.Racetracks.Common.Messages
{
    public class CostMatrixResponseMessage // todo rename to ..ChangedMessage for all response messages
    {
        [NotNull]
        public double[][] Matrix = new double[0][];
    }
}