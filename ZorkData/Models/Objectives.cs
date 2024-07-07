using ZorkData.Models.Base;

namespace ZorkData.Models
{
    public class Objectives : BaseClass
    {
        public int SequenceNumber { get; set; }
        public virtual IEnumerable<Objectives>? Tasks { get; set; }
        public virtual State? State { get; set; }
    }
}