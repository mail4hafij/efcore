﻿using common.contract.model;
using src.db.data.model;

namespace src.db.repo
{
    public interface ILandlordRepository : IDisposable
    {
        Task Add(Landlord landlord);

        LandlordContract GetLandlord();
    }
}
