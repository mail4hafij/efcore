using Microsoft.EntityFrameworkCore.Storage;

namespace src.db
{
    public interface IUnitOfWork
    {
        IDbContextTransaction BeginTransaction();
    }
}
