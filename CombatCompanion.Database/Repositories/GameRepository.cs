using CombatCompanion.Database.Models;
using MongoDB.Driver;

namespace CombatCompanion.Database.Repositories;

public class GameRepository : BaseRepository<Game>
{
    public GameRepository(IMongoClient mongoClient) : base(mongoClient)
    {
    }
}