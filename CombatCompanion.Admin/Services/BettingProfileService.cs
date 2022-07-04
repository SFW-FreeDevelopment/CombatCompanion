using CombatCompanion.Admin.Services.Interfaces;
using CombatCompanion.Database.Models;

namespace CombatCompanion.Admin.Services;

public class BettingProfileService : ICombatService<BettingProfile>
{
    public Task<List<BettingProfile>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<BettingProfile> GetById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<BettingProfile> Create(BettingProfile data)
    {
        throw new NotImplementedException();
    }

    public Task<BettingProfile> Update(string id, BettingProfile data)
    {
        throw new NotImplementedException();
    }

    public Task Delete(string id)
    {
        throw new NotImplementedException();
    }
}