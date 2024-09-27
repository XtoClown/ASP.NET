namespace lr_three.Services
{
    public interface IDayTimeInfo
    {
        string Info();
    }
    public class DayTimeInfo: IDayTimeInfo
    {
        private readonly IConfiguration _configuration;
        public DayTimeInfo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Info()
        {
            DateTime date = DateTime.Now;
            int hour = date.Hour;
            if (hour >= 0 && hour < 6) 
            {
                return "It's nighttime";
            }
            else if(hour >= 6 && hour < 12)
            {
                return "It's morning";
            }
            else if (hour >= 12 && hour < 18)
            {
                return "It's daytime";
            }
            else
            {
                return "It's evening";
            }
        }
    }
}
