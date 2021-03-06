using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampion.Moldels
{
    [Table("Veriler")]
    public class Veri
    {
        public int Id { get; set; }
        public string Takim1 { get; set; }
        public string Takim2 { get; set; }
        public string Tarih { get; set; }
        public int Skor1 { get; set; }
        public int Skor2 { get; set; }
        public string Durum { get; set; }
    }
}
