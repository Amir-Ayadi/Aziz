using Microsoft.EntityFrameworkCore;

namespace Aziz.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
            //Vide pour le moment 
            // au cas on a besoin du dummy data .
        } 

        public DbSet<Contrat> Contrats { get; set; }
    }
}
