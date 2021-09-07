namespace Api.Domain.Security
{
    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issurer { get; set; }
        public int Seconds { get; set; }
    }
}