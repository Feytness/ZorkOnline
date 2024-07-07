using Microsoft.AspNetCore.Components;
using ZorkData.Models;

namespace ZorkOnline.Components.Pages
{
    public partial class EditWorld : ComponentBase
    {
        public int SelectedWorld { get; set; }

        public List<World> WorldList { get; set; }

        public World CurrentWorld { get; set; }

        public EditWorld()
        {
            SelectedWorld = 0;
            WorldList = new List<World>();
            CurrentWorld = new World();
        }

        public void SelectWorld()
        {
            CurrentWorld = WorldList.FirstOrDefault(x => x.Id == SelectedWorld);
        }
    }
}
