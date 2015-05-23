using JetBrains.Annotations;

namespace Selkie.Services.Racetracks.Common.Messages
{
    public class CostMatrixChangedMessage
    {
        [CanBeNull]
        public double[][] Matrix;
    }
}