using CombatCompanion.Database.Models;
using MongoDB.Driver;

namespace CombatCompanion.Database.Repositories;

public class WalletRepository : BaseRepository<Wallet>
{
    public WalletRepository(IMongoClient mongoClient) : base(mongoClient)
    {
    }
}