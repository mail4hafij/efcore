
namespace src.db.data.mapper
{
    public interface ILandlordMapper
    {
        common.contract.model.LandlordContract Map(data.model.Landlord landlord);
    }
}
