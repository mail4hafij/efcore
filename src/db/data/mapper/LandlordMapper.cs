
namespace src.db.data.mapper
{
    public class LandlordMapper : ILandlordMapper
    {
        public common.contract.model.LandlordContract Map(data.model.Landlord landlord)
        {
            return new common.contract.model.LandlordContract
            {
                LandlordId = landlord.LandlordId,
                Name = landlord.Name
            };
        }
    }
}
