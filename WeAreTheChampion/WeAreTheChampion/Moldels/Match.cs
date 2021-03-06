using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampion.Moldels
{
    [Table("Matchs")]
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public DateTime? MatchTime { get; set; }
        public int? Score1 { get; set; }
        public int? Score2 { get; set; }
        public int Durumlar { get; set; }
        public int IcSahaId { get; set; }
        public virtual Team IcSahalar { get; set; }
        public int DısSahaId { get; set; }
        public virtual Team DısSahalar { get; set; }
        public Result Result { get; set; }
    }
}
