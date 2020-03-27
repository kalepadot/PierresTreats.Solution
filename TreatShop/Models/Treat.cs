using System.Collections.Generic;

namespace TreatShop.Models
{
  public class Treat
    {
        public Treat()
        {
            this.Flavor = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FlavorTreat> Flavors { get; set; }
    }
}