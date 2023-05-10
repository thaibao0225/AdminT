using System.ComponentModel;

namespace Client.Models
{
    public class ProductsModel
    {
        [DisplayName("Id")]
        public string pd_Id { set; get; }
        [DisplayName("Name Product")]
        public string pd_Name { set; get; }
        [DisplayName("Description")]
        public string pd_Description { set; get; }
        [DisplayName("Price")]
        public int pd_Price { set; get; }
        [DisplayName("ReducePrice")]
        public int pd_ReducePrice { set; get; }
        public string pd_NameImg1 { set; get; }
        public string pd_NameImg2 { set; get; }
        public string pd_NameImg3 { set; get; }
        public string pd_NameImg4 { set; get; }
        public string pd_Img1 { set; get; }
        public string pd_Img2 { set; get; }
        public string pd_Img3 { set; get; }
        public string pd_Img4 { set; get; }
        [DisplayName("Rate")]
        public int pd_Rate { set; get; }
        public string pd_ShortDescription { set; get; }
        public bool pd_WaitForConfirmation { set; get; }
        public bool isDelete { set; get; }
        public string categoryName { set; get; }
        public string categorySex { set; get; }

    }
}
