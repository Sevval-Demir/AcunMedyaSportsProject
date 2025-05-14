using AcunMedyaSportsProject.WebApi.Enums;

namespace AcunMedyaSportsProject.WebApi.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public DateTime StartDate { get; set; }
        public int? HomeScore { get; set; }
        public int? AwayScore { get; set; }
        public string Saloon { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public MatchStatus MatchStatus { get; set; }
        public List<MatchSet> MatchSets { get; set; }
    }
}
