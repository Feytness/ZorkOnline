using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorkData.Models.Base;

namespace ZorkData.Models
{
    public class Characters : BaseClass
    {
        public int CurrentHealth {  get; set; }
        public int MaxHealth { get; set; }
        public int CurrentMP { get; set; }
        public int MaxMP { get; set; }
        public Levels? Level { get; set; }
        public string? AsciiImage { get; set; }

        public virtual Locations? CurrentLocation { get; set; }
        public virtual IEnumerable<Items>? Items { get; set; }

    }
}
