using ZorkData.Models.Base;

namespace ZorkData.Models
{
    public class Locations : BaseClass
    {
        public virtual State? State { get; set; }
        public virtual IEnumerable<Items>? Items { get; set; }
        public virtual IEnumerable<Exits>? Exits { get; set; }
    }
}
