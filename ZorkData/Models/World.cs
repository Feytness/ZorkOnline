using ZorkData.Models.Base;

namespace ZorkData.Models
{
    public class World : BaseClass
    {
        public virtual IEnumerable<Locations>? Locations { get; set; }
        public State? State { get; set; }
    }
}
