
namespace src.db
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context) => _context = context;

        public async Task<bool> Commit()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void Dispose() => _context.Dispose();

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
