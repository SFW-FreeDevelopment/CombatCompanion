using CombatCompanion.Admin.Services;
using CombatCompanion.Database.Models;
using Microsoft.AspNetCore.Components;

namespace CombatCompanion.Admin.Pages.Events;

public partial class CreateEdit
    {
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private EventService EventService { get; set; }
        
        [Parameter] public string Id { get; set; }
        
        private Event _event;

        private bool _loadFailed;
        private Exception _exception;
        
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
            
            try
            {
                if (Id != null)
                {
                    _event = await EventService.GetById(Id);
                    if (_event == null)
                    {
                        NavigationManager.NavigateTo("/events");
                    }
                }
                else
                {
                    _event = new Event();
                }
            }
            catch(Exception e)
            {
                _loadFailed = true;
                _exception = e;
                NavigationManager.NavigateTo("/events");
            }
        }
    
        private async Task HandleValidSubmit()
        {
            _event = await EventService.Create(_event);
        }
    
        private async Task Submit()
        {
            if (Id != null)
            {
                _event = await EventService.Update(Id, _event);
            }
            else
            {
                _event = await EventService.Create(_event);
            }
            NavigationManager.NavigateTo("/events");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("/events");
        }
    }