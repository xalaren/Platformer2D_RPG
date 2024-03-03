namespace Platformer_2D_RPG.Game
{
    class Time
    {
        public int Milliseconds { get; set; }
        public int Seconds { get; set; }
        public int Minutes { get; set; }

        public void Clear()
        {
            Milliseconds = 0;
            Seconds = 0;
            Minutes = 0;
        }

        public string GetTime()
        {
            return $"{Minutes:00} min. {Seconds:00} sec.";
        }
    }
}
