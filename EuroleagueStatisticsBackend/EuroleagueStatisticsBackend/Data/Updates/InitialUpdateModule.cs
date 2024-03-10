using EuroleagueStatisticsBackend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EuroleagueStatisticsBackend.Data.Updates
{
    public class InitialUpdateModule
    {
        private readonly StatisticsDbContext _DbContext;
        public InitialUpdateModule(StatisticsDbContext dbContext) 
        { 
            _DbContext = dbContext;
        }
        public async Task UpdateAsync() 
        {
            List<Player> players = _DbContext.Players.ToList();

            foreach (var player in players)
            {
                player.GamesPlayed = 0;
                player.Wins = 0;
                player.Losses = 0;
                player.Time = 0;
                player.Fgm = 0;
                player.Fga = 0;
                player.Fg = 0;
            }

            string apiUrl = "https://live.euroleague.net/api/Boxscore?gamecode=1&seasoncode=E2023";

            string jsonString = await GetApiData(apiUrl);

            GameStats gameStats = JsonConvert.DeserializeObject<GameStats>(jsonString);

            //foreach (var teamStat in gameStats.Stats)
            //{
            //    Console.WriteLine($"Team: {teamStat.Team}, Coach: {teamStat.Coach}");
            //    foreach (var playerStat in teamStat.PlayersStats)
            //    {
            //        Player player = players.FirstOrDefault(p => p.Name == playerStat.Player);

            //        if(player != null)
            //        {
            //            var opposingTeam = gameStats.Stats.FirstOrDefault(s => s.Team != teamStat.Team);

            //            if(playerStat.Minutes != "DNP")
            //            {
            //                player.GamesPlayed += 1;

            //                if (teamStat.totr.Points > opposingTeam.totr.Points)
            //                {
            //                    player.Wins += 1;
            //                }
            //                else
            //                {
            //                    player.Losses += 1;
            //                }

            //                string minutesSubstring = playerStat.Minutes.Substring(0, 2);
            //                string secondsSubstring = playerStat.Minutes.Substring(3, 2);
            //                int minutes = int.Parse(minutesSubstring);
            //                int seconds = int.Parse(secondsSubstring);
            //                player.Time += minutes * 60 + seconds;
            //            }
                        
            //            if(playerStat.FieldGoalsAttempted2 + playerStat.FieldGoalsAttempted3 != 0)
            //            {
            //                player.Fgm += playerStat.FieldGoalsMade2 + playerStat.FieldGoalsMade3;
            //                player.Fga += playerStat.FieldGoalsAttempted2 + playerStat.FieldGoalsAttempted3;
            //                player.Fg = player.Fgm / player.Fga;
            //            }
                        
            //        }
            //        Console.WriteLine($"Player: {playerStat.Player}, Points: {playerStat.Points}");
            //    }
            //}

            _DbContext.SaveChanges();
        }

        private static async Task<string> GetApiData(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();

                        Console.WriteLine("Got apiResponse!\n");
                        return apiResponse;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
