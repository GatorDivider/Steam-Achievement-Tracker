using System.Collections.Generic;

namespace SteamAchievementTracker
{
    public class StatisticsManager
    {
        public List<string> Games { get; set; } = new();

        public int TotalGames => Games.Count;
    }
}
