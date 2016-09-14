using System;
using JetBrains.Annotations;

namespace Selkie.Services.Racetracks.Common.Messages
{
    [UsedImplicitly]
    public class CostMatrixResponseMessage // todo rename to ..ChangedMessage for all response messages
    {
        [UsedImplicitly]
        public Guid ColonyId;

        [NotNull]
        [UsedImplicitly]
        public double[][] Matrix = new double[0][];
    }
}