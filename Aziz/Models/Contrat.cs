using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aziz.Models
{
    [Table("Contrat")]
    public class Contrat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContratId { get; set;}
        public string ContratName { get; set;} = string.Empty;
        public string ContratType { get; set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
