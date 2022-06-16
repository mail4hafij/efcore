
namespace src.db
{
    public abstract class RepositoryBase
    {
        private readonly DataContext _context;

        public RepositoryBase(DataContext context)
        {
            _context = context;
        }
    }
}
