namespace DemoHub.Domain.Entities
{
    public class CTNForeignExchangeDetail
    {
        public int ForeignExchangeDetailID { get; set; }
        public decimal? ToAmount { get; set; }
        public decimal? FromAmount { get; set; }
        public string UnitCurrency { get; set; }
        public string QuotedCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
