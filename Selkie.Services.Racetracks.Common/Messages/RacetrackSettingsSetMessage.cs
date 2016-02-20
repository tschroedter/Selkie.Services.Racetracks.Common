namespace Selkie.Services.Racetracks.Common.Messages
{
    public class RacetrackSettingsSetMessage
    {
        public bool IsPortTurnAllowed;
        public bool IsStarboardTurnAllowed;
        public double TurnRadiusForPort;
        public double TurnRadiusForStarboard;
    }
}