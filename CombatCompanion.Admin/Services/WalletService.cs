using CombatCompanion.Admin.Services.Interfaces;
using CombatCompanion.Database.Models;

namespace CombatCompanion.Admin.Services;

public class WalletService : ICombatService<Wallet>
{
    public Task<List<Wallet>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Wallet> GetById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Wallet> Create(Wallet data)
    {
        throw new NotImplementedException();
    }

    public Task<Wallet> Update(string id, Wallet data)
    {
        throw new NotImplementedException();
    }

    public Task Delete(string id)
    {
        throw new NotImplementedException();
    }
}