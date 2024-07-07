using ZorkData.Models.Base;

namespace ZorkData.Models
{
    public class Items : BaseClass
    {
        public decimal Weight { get; set; }
        public Rarity? ItemRarity { get; set; }
        public decimal Value { get; set; } 
        public int HPModifyer { get; set; }
        public int MPModifyer { get; set; }
    }
}
