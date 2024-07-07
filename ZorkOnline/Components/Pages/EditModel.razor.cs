using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using ZorkData.Models;
using ZorkOnline.Components.Templates;

namespace ZorkOnline.Components.Pages
{
    public partial class EditModel : ComponentBase
    {
        private Rarity formData = new Rarity();

        private async Task HandleFormSubmission(Rarity model)
        {
            // Handle form submission logic here
            // Example: Save to database, send to server, etc.
            // For demonstration, let's just print the model to console
            Console.WriteLine("Form submitted:");
            Console.WriteLine(JsonConvert.SerializeObject(model));

            // You can also perform any navigation logic here
            // Example: NavigationManager.NavigateTo("/success");
        }
    }
}
