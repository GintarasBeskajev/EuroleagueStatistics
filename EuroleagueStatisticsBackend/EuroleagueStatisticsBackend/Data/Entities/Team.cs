using System.Reflection.Metadata;

namespace EuroleagueStatisticsBackend.Data.Entities
{
    public class Team
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Abbreviation { get; set; }
        public required string Country { get; set; }
        public required string City { get; set; }
        public required string Coach { get; set; }
        public required string Logo { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public double Time { get; set; }
        public double Fgm { get; set; }
        public double Fga { get; set; }
        public double Fg { get; set; }
        public double Ftm { get; set; }
        public double Fta { get; set; }
        public double Ft { get; set; }
        public double Points { get; set; }
        public double ORebounds { get; set; }
        public double DRebounds { get; set; }
        public double Rebounds { get; set; }
        public double Assists { get; set; }
        public double Turnovers { get; set; }
        public double Steals { get; set; }
        public double Blocks { get; set; }
        public double BlocksAllowed { get; set; }
        public double PersonalFouls { get; set; }
        public double PersonalFoulsDrawn { get; set; }
        public double PlusMinus { get; set; }
        public double ORating {  get; set; }
        public double DRating { get; set; }
        public double NetRating { get; set; }
        public double TrueShooting { get; set; }
        public double Efficiency { get; set; }
        public double Pace { get; set; }
        public double Possesions { get; set; }
    }
}
