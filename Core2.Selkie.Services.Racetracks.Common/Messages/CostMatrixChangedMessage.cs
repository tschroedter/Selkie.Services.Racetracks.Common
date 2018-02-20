using JetBrains.Annotations;

namespace Core2.Selkie.Services.Racetracks.Common.Messages
{
    public class CostMatrixChangedMessage
    {
        [CanBeNull]
        public double[][] Matrix;
    }
}