namespace AcunMedyaSportsProject.WebApi.Entities
{
    public class MatchSet
    {
        public int MatchId { get; set; }
        public int SetNumber { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public Match Match { get; set; }

    }
}
