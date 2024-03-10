namespace EuroleagueStatisticsBackend.Data.Updates
{
    public class GameInfo
    {
        public bool Live { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public string CodeTeamA { get; set; }
        public string CodeTeamB { get; set; }
        public int ActualQuarter { get; set; }
        public List<Play> FirstQuarter { get; set; }
        public List<Play> SecondQuarter { get; set; }
        public List<Play> ThirdQuarter { get; set; }
        public List<Play> ForthQuarter { get; set; }
    }
}
