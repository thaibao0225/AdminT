using Client.Models;

namespace Client.Service.Interface
{
    public interface IBillService
    {
        public List<BillListModel> GetAllBill();
        public List<BillListModel> GetAllBillByUserId(string userId);
        public Task<bool> CreateBillForUser(IFormCollection collection, string userId, List<ProductsInCartModel> productsInCartModel);
        public Task<bool> ChangeConfirmStatus(string billId);
        public Task<bool> ChangeWaitPickupStatus(string billId);
        public Task<bool> ChangeDeliveringStatus(string billId);
        public Task<bool> ChangeDeliveredStatus(string billId);
        public Task<bool> ChangeCancelledStatus(string billId);
    }
}
