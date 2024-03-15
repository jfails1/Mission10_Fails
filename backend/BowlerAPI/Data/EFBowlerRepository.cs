namespace BowlerAPI.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private readonly BowlerContext _context;

        public EFBowlerRepository(BowlerContext context)
        {
            _context = context;
        }

        public IEnumerable<BowlerInfo> Bowlers => _context.Bowlers;
        public IEnumerable<TeamInfo> Teams => _context.Teams;
    }

}
