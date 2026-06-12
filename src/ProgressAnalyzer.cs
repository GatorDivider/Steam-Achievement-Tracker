namespace SteamAchievementTracker
{
    public class ProgressAnalyzer
    {
        public string Analyze(double completionRate)
        {
            if (completionRate >= 90)
                return "Completion Master";

            if (completionRate >= 70)
                return "Advanced Hunter";

            if (completionRate >= 50)
                return "Dedicated Player";

            return "Getting Started";
        }
    }
}
