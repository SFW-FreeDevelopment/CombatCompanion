using CombatCompanion.Admin.Services;
using CombatCompanion.Database.Models;
using Microsoft.AspNetCore.Components;
using Radzen.Blazor;

namespace CombatCompanion.Admin.Pages.Fighters;

public partial class Index
{
    [Inject] private FighterService FighterService { get; set; }
    [Inject] private NavigationManager NavigationManager { get; set; }

    
    private List<Fighter> _fighters;

    private RadzenGrid<Event> _grid;

    private bool _loadFailed;
    private Exception _exception;

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();
        
        try
        {
            _fighters = await FighterService.GetAll();
        }
        catch (Exception e)
        {
            _loadFailed = true;
            _exception = e;
        }
    }

    private void Create()
    {
        NavigationManager.NavigateTo("/fighters/add");
    }

    private void Edit(string fighterId)
    {
        NavigationManager.NavigateTo($"/fighters/{fighterId}/edit");
    }
}