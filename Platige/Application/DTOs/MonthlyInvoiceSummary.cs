namespace Platige.Application.DTOs
{
    public class MonthlyInvoiceSummary
    {
        public string YearMonth { get; set; } = string.Empty;
        public decimal TotalNetValue { get; set; }
        public decimal TotalGrossValue { get; set; }
    }
}
