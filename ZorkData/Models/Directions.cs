using System.Reflection.Metadata;
using ZorkData.Models.Base;

namespace ZorkData.Models
{
    public class Directions : BaseClass
    {
        public List<string> AltDirectionNames { get; set; }

        public Directions(string name, List<string> altNames)
        {
            Name = name;
            AltDirectionNames = altNames;
        }
    }
}