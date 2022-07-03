using CombatCompanion.Admin.Services.Interfaces;
using CombatCompanion.Database.Models;

namespace CombatCompanion.Admin.Services;

public class EventService : ICombatService<Event>
{
    public Task<List<Event>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Event> GetById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Event> Create(Event data)
    {
        throw new NotImplementedException();
    }

    public Task<Event> Update(string id, Event data)
    {
        throw new NotImplementedException();
    }

    public Task Delete(string id)
    {
        throw new NotImplementedException();
    }
}