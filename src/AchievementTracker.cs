namespace SteamAchievementTracker
{
    public class AchievementTracker
    {
        public int TotalAchievements { get; set; }

        public int UnlockedAchievements { get; set; }

        public double GetCompletionRate()
        {
            if (TotalAchievements == 0)
                return 0;

            return (double)UnlockedAchievements / TotalAchievements * 100;
        }
    }
}
