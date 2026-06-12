using System.Text;

namespace SteamAchievementTracker
{
    public class ReportGenerator
    {
        public string Generate()
        {
            StringBuilder builder = new();

            builder.AppendLine("Steam Achievement Tracker Report");

            return builder.ToString();
        }
    }
}
