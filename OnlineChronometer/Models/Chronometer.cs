namespace OnlineChronometer.Models
{
    public class Chronometer
    {
        public int Time { get; set; } = 0;
        public bool IsRunning { get; set; } = false;
        public List<string> Laps { get; set; } = new();
    }
}
