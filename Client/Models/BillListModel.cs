namespace Client.Models
{
    public class BillListModel
    {
        public string Id { get; set; } = string.Empty; 
        public string ProductNameList { get; set; } = string.Empty;
        public string ProductIdList { get; set; } = string.Empty;
        public string ProductPriceList { get; set; } = string.Empty;
        public string ProductQuantityList { get; set; } = string.Empty; 
        public string ProductColorList { get; set; } = string.Empty; 
        public string ProductSizeList { get; set; } = string.Empty; 
        public string ProductSumPriceList { get; set; } = string.Empty; 


        public string ProductDiscount { get; set; } = string.Empty;
    }
}
