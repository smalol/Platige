using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Platige.Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać numer faktury.")]
        [StringLength(30, ErrorMessage = "Numer faktury może zawierać maksymalnie 30 znaków.")]
        public required string Number { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Kwota netto faktury musi być większa od zera.")]
        public decimal NetValue { get; set; }

        [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = "Nazwa waluty musi składać się z 3 wielkich liter.")]
        public string Currency { get; set; } = "PLN";

        [Range(0, 100, ErrorMessage = "Stawka VAT musi być większa lub równa zero.")]
        public decimal VatRate { get; set; }

        [Required(ErrorMessage = "Proszę podać datę sprzedaży.")]
        public DateTime SaleDate { get; set; }

        public string? Description { get; set; }

        public int ContractorId { get; set; }

        public required Contractor Contractor { get; set; }
    }
}
