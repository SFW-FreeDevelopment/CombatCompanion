using CombatCompanion.Database.Models;
using MongoDB.Driver;

namespace CombatCompanion.Database.Repositories;

public class EventRepository : BaseRepository<Event>
{
    public EventRepository(IMongoClient mongoClient) : base(mongoClient)
    {
        CollectionName = "events";
    }
}