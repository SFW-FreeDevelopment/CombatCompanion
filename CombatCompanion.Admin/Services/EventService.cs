using CombatCompanion.Admin.Services.Interfaces;
using CombatCompanion.Database.Models;
using CombatCompanion.Database.Repositories;

namespace CombatCompanion.Admin.Services;

public class EventService : ICombatService<Event>
{
    private readonly EventRepository _eventRepository;

    public EventService(EventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }
    
    public async Task<List<Event>> GetAll()
    {
        return await _eventRepository.GetAll();
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