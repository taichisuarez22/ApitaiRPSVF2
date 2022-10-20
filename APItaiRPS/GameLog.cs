namespace APItaiRPS
{
    public class GameLog
    {
        public int Id { get; set; }
        public string Player1 { get; set; } = String.Empty;
        public string Player2 { get; set; } = String.Empty;
        public string Victory { get; set; } = String.Empty;
        public string Defeat { get; set; } = String.Empty;
        public int TotalRounds { get; set; }

    }
}
