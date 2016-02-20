namespace Selkie.Services.Racetracks.Common.Messages
{
    public class RacetrackSettingsChangedMessage
    {
        public bool IsPortTurnAllowed;
        public bool IsStarboardTurnAllowed;
        public double TurnRadiusForPort;
        public double TurnRadiusForStarboard;
    }
}