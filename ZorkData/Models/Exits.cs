using ZorkData.Models.Base;

namespace ZorkData.Models
{
    public class Exits : BaseClass
    {
        public Directions? ExitDirection { get; set; }
        public virtual Locations? Location { get; set; }
    }
}