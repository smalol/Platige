using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Platige.Domain.Entities
{
    public class Contractor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać rodzaj kontrahenta.")]
        [StringLength(20, ErrorMessage = "Pole określające rodzaj kontrahenta może zawierać maksymalnie 20 znaków.")]
        public required string Type { get; set; } 

        [Required(ErrorMessage = "Proszę podać nazwę kontrahenta.")]
        [StringLength(50, ErrorMessage = "Pole określające nazwę kontrahenta może zawierać maksymalnie 50 znaków.")]
        public required string Name { get; set; } 

        [Required(ErrorMessage = "Proszę podać skróconą nazwę kontrahenta.")]
        [StringLength(20, ErrorMessage = "Pole określające skróconą nazwę kontrahenta może zawierać maksymalnie 20 znaków.")]
        public required string ShortName { get; set; }

        [Required(ErrorMessage = "Proszę podać kraj kontrahenta.")]
        [StringLength(20, ErrorMessage = "Pole określające kraj może zawierać maksymalnie 20 znaków.")]
        public required string Country { get; set; }

        [Required(ErrorMessage = "Proszę podać adres kontrahenta.")]
        [StringLength(100, ErrorMessage = "Pole z adresem może zawierać maksymalnie 100 znaków.")]
        public required string Address { get; set; }

        [Required(ErrorMessage = "Proszę podać numer NIP kontrahenta.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Numer NIP musi zawierać dokładnie 10 cyfr.")]
        public required string NIP { get; set; }

        public bool IsActive { get; set; } = false;

        [XmlIgnore]
        public ICollection<Invoice>? Invoices { get; set; }
    }
}
