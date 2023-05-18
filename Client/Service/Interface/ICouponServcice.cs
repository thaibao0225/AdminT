using Client.Models;

namespace Client.Service.Interface
{
    public interface ICouponServcice
    {
        public List<CouponModel> GetAllCoupon();
        public Task<bool> SetCoupon(string couponCode, int couponPrice = 0);
        public CouponModel GetCoupon(string couponCode);
    }
}
