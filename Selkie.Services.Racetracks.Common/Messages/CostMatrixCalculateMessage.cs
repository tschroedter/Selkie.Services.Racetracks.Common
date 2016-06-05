using JetBrains.Annotations;
using Selkie.Services.Common.Dto;

namespace Selkie.Services.Racetracks.Common.Messages
{
    [UsedImplicitly]
    public class CostMatrixCalculateMessage
    {
        [UsedImplicitly]
        public bool IsPortTurnAllowed;
        
        [UsedImplicitly]
        public bool IsStarboardTurnAllowed;
        
        [NotNull]
        [UsedImplicitly]
        public SurveyFeatureDto[] SurveyFeatureDtos = new SurveyFeatureDto[0];
        
        [UsedImplicitly]
        public double TurnRadiusForPort;
        
        [UsedImplicitly]
        public double TurnRadiusForStarboard;
    }
}