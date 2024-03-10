namespace EuroleagueStatisticsBackend.Data.Updates
{
    public class GameStats
    {
        public bool Live { get; set; }
        public string Referees { get; set; }
        public string Attendance { get; set; }
        public List<QuarterStats> ByQuarter { get; set; }
        public List<QuarterStats> EndOfQuarter { get; set; }
        public List<TeamStats> Stats { get; set; }
    }
}
