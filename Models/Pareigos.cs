using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Krepsinio_varzybos.Models
{
    public class Pareigos
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Pavadinimas")]
        [MaxLength(40)]
        [Required]
        public string Pavadinimas { get; set; }
    }
}
