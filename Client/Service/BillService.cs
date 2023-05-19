using Client.Data;
using Client.Entites;
using Client.Models;
using Client.Service.Interface;

namespace Client.Service
{
    public class BillService : IBillService
    {
        private readonly ApplicationDbContext _context;
        private readonly CartService _cartService;
        public BillService(ApplicationDbContext context)
        {

            _context = context;
            _cartService = new CartService(context);
        }

        public async Task<bool> CreateBillForUser(IFormCollection collection, string userId, List<ProductsInCartModel> productsInCartModel
            )
        {

            string firstName = collection["firstName"];
            string lastName = collection["lastName"];
            string country = collection["country"];
            string address = collection["address"];
            string city = collection["city"];
            string zip = collection["zip"];
            string phone = collection["phone"];
            string email = collection["email"];
            string discount = collection["discount"];

            // Add information
            var user = _context.AppUser.FirstOrDefault(x => x.Id == userId);
            
            if (user != null)
            {
                user.FirstName = firstName;
                user.LastName = lastName;
                user.bill_Address1 = address;
                user.bill_City = city;
                user.bill_PostalCode = zip;
                user.PhoneNumber = phone;
                user.Email = email;
                _context.AppUser.Update(user);
            }


            //Create Bill
            var productList = ConvertStringToListBill(productsInCartModel);

            Bills bill = new Bills();
            bill.bill_Id = Guid.NewGuid().ToString();
            bill.bill_UserId = userId;
            bill.bill_ProductIdlist = productList.ProductIdList;
            bill.bill_ProductNamelist = productList.ProductNameList;
            bill.bill_ProductSizelist = productList.ProductSizeList;
            bill.bill_ProductColorlist = productList.ProductColorList;
            bill.bill_ProductPricelist = productList.ProductSumPriceList;
            bill.bill_Quantity = productList.ProductQuantityList;
            bill.bill_Shipping = 0;
            bill.bill_Discount = int.Parse(discount);
            bill.bill_PaidTotal = _cartService.GetTotalPrice(productsInCartModel);
            bill.bill_Confirmation = false;
            bill.bill_PaymentMethod = "Cash";
            bill.bill_Note = "";
            bill.bill_DatetimeOrder = DateTime.Now;

            _context.Bills.Add(bill);

            await _context.SaveChangesAsync();


            
            return true;
        }


        public BillListModel ConvertStringToListBill(List<ProductsInCartModel> productsInCartModel)
        {
            BillListModel billListModel = new BillListModel();

            foreach (var item in productsInCartModel)
            {
                billListModel.ProductNameList = billListModel.ProductNameList + item.pic_ProductName + "|";
                billListModel.ProductSumPriceList = billListModel.ProductSumPriceList + item.pic_SumPrice + "|";
                billListModel.ProductPriceList = billListModel.ProductPriceList + item.pic_ProductPrice + "|";
                billListModel.ProductColorList = billListModel.ProductColorList + item.pic_color + "|";
                billListModel.ProductIdList = billListModel.ProductIdList + item.pic_ProductId + "|";
                billListModel.ProductQuantityList = billListModel.ProductQuantityList + item.pic_quantity + "|";
                billListModel.ProductSizeList = billListModel.ProductSizeList + item.pic_size + "|";
            }

            return billListModel;
        }


        public string GetBillId(string userId)
        {
            var bill = _context.Bills.FirstOrDefault(x => x.bill_UserId == userId);
            if(bill != null)
            {
                return bill.bill_Id;
            }
            return "";
        }

        public string SetBill()
        {
            string billId = Guid.NewGuid().ToString();

            Bills bills = new Bills()
            {
                bill_Id = billId

            };
            return "";
        }

        public string GenericListInBill(string listedGen, string item, string commad)
        {
            return listedGen + commad + item;
        }
    }
}
