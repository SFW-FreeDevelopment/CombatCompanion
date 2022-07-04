using CombatCompanion.Database.Models;
using MongoDB.Driver;

namespace CombatCompanion.Database.Repositories;

public class FighterRepository : BaseRepository<Fighter>
{
    public FighterRepository(IMongoClient mongoClient) : base(mongoClient)
    {
        CollectionName = "fighters";
    }
}