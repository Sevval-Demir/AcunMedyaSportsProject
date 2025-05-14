namespace AcunMedyaSportsProject.WebApi.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FoundedYear { get; set; }
        public string Saloon { get; set; }
        public string IsoCode { get; set; }
        public List<Match> HomeTeamMatches { get; set; }
        public List<Match> AwayTeamMatches { get; set; }

    }
}
