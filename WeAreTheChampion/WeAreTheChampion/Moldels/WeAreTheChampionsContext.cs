using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampion.Moldels
{
   public class WeAreTheChampionsContext :DbContext
    {
        public WeAreTheChampionsContext() : base("name=BaglantiCumlem")
        {

        }
        
        public DbSet<Team> Teams { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matchs { get; set; }
        public DbSet<Veri> Veriler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
