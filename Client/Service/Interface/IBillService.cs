using Client.Models;

namespace Client.Service.Interface
{
    public interface IBillService
    {
        public List<BillListModel> GetAllBillByUserId(string userId);
    }
}
