using ZorkData.Models.Base;

namespace ZorkData.Models
{
    public class Missions : BaseClass
    {
        public virtual Dialogue? Dialogue { get; set; }
        public virtual Locations? Location { get; set; }
        public virtual IEnumerable<Objectives>? Objectives { get; set; }
    }
}
