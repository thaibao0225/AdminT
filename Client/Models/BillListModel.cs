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

        public string UserName { set; get; } = string.Empty;
        public int bill_PaidTotal { set; get; }
        public int bill_Shipping { set; get; }
        public int bill_Discount { set; get; }
        public bool bill_Confirmation { set; get; }
        public DateTime bill_DatetimeOrder { set; get; }
        public bool bill_WaitForConfirmation { set; get; }
        public bool bill_WaitPickup { set; get; }
        public bool bill_Delivering { set; get; }
        public bool bill_Delivered { set; get; }
        public bool bill_Cancelled { set; get; }




        public string ProductDiscount { get; set; } = string.Empty;
    }
}
