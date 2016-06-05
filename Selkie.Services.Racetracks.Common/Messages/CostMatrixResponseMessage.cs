using JetBrains.Annotations;

namespace Selkie.Services.Racetracks.Common.Messages
{
    [UsedImplicitly]
    public class CostMatrixResponseMessage // todo rename to ..ChangedMessage for all response messages
    {
        [NotNull]
        [UsedImplicitly]
        public double[][] Matrix = new double[0][];
    }
}