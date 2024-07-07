using ZorkData.Models.Base;

namespace ZorkData.Models
{
    public class Dialogue : BaseClass
    {
        public virtual Characters? Character { get; set; }
        public virtual Items? Item { get; set; }

        public string? DialogueText { get; set; }
        public virtual IEnumerable<Dialogue>? DialogueOptions { get; set; }
    }
}
