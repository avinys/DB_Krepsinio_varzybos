using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Krepsinio_varzybos.Models
{
    public class ZaidejasF2
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Vardas")]
        [MaxLength(20)]
        public string Vardas { get; set; }

        [DisplayName("Pavarde")]
        [MaxLength(20)]
        public string Pavarde { get; set; }
    }
}
