using OnlineChronometer.Models;

namespace OnlineChronometer.Services
{
    public class ChronometerService
    {
        public Chronometer Model { get; private set; } = new();

        public void Start()
        {
            Model.IsRunning = true;
        }

        public void Pause()
        {
            Model.IsRunning = false;
        }

        public void Reset()
        {
            Model = new Chronometer();
        }

        public void IncrementTime()
        {
            if (Model.IsRunning)
                Model.Time++;
        }

        public void AddLap()
        {
            int minutes = Model.Time / 60;
            int seconds = Model.Time % 60;

            string LapTime = $"{minutes:D2}:{seconds:D2}";
            Model.Laps.Add(LapTime);
        }
    }
}