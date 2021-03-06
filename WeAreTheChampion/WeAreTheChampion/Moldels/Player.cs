using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampion.Moldels
{
    [Table("Players")]
    public class Player
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int? TeamId { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
