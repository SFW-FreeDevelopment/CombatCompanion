using CombatCompanion.Database.Models;
using MongoDB.Driver;

namespace CombatCompanion.Database.Repositories;

public class BettingProfileRepository : BaseRepository<BettingProfile>
{
    public BettingProfileRepository(IMongoClient mongoClient) : base(mongoClient)
    {
    }
}