using common.contract.model;
using src.db.data.mapper;
using src.db.data.model;

namespace src.db.repo
{
    public class LandlordRepository : ILandlordRepository
    {
        private readonly DataContext _context;
        private readonly ILandlordMapper _landlordMapper;

        public LandlordRepository(DataContext context, ILandlordMapper landlordMapper)
        {
            _context = context;
            _landlordMapper = landlordMapper;
        }

        public async Task Add(Landlord landlord)
        {
            await _context.Landlords.AddAsync(landlord);
        }

        public LandlordContract GetLandlord()
        {
            var landlord = _context.Landlords.First<Landlord>();
            return _landlordMapper.Map(landlord);
        }

        private bool _disposed = false;

        ~LandlordRepository() => Dispose();

        public void Dispose()
        {
            if (!_disposed)
                _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
