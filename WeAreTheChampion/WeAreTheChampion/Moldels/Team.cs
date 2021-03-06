using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampion.Moldels
{
    [Table("Teams")]
    public class Team
    {
        
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string TeamName { get; set; }
        public string RenkAdi1 { get; set; }
        public string RenkAdi2 { get; set; }
        public string RenkAdi3 { get; set; }
        public string RenkAdi4 { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<Match> IcSahalar { get; set; }
        public virtual ICollection<Match> DısSahalar { get; set; }
    }
}
