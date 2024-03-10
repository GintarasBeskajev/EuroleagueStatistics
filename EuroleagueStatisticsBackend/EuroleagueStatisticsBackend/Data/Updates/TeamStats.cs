namespace EuroleagueStatisticsBackend.Data.Updates
{
    public class TeamStats
    {
        public string Team { get; set; }
        public string Coach { get; set; }
        public List<PlayerStats> PlayersStats { get; set; }
        //public PlayerStats tmr { get; set; }
        public PlayerStats totr { get; set; }
    }
}
