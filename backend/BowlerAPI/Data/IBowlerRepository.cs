namespace BowlerAPI.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<BowlerInfo> Bowlers { get; }
        IEnumerable<TeamInfo> Teams { get; }
    }
}
