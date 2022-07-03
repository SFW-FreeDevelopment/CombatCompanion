using CombatCompanion.Admin.Services;
using CombatCompanion.Database.Models;
using Microsoft.AspNetCore.Components;
using Radzen.Blazor;

namespace CombatCompanion.Admin.Pages.Events;

public partial class Index
{
    [Inject] private EventService EventService { get; set; }
    [Inject] private NavigationManager NavigationManager { get; set; }

    
    private List<Event> _events;

    private RadzenGrid<Event> grid;

    private bool _loadFailed;
    private Exception exception;

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();
        
        try
        {
            _events = await EventService.GetAll();
        }
        catch (Exception e)
        {
            _loadFailed = true;
            exception = e;
        }
    }

    private void Create()
    {
        NavigationManager.NavigateTo("/events/add");
    }

    private void Edit(string eventId)
    {
        NavigationManager.NavigateTo($"/events/{eventId}/edit");
    }
}