using Client.Models;

namespace Client.Service.Interface
{
    public interface ICouponServcice
    {
        public List<CouponModel> GetAllCoupon();
        public Task<bool> SetCoupon(CouponModel couponModel);
        public CouponModel GetCoupon(string couponCode);
        public CouponModel GetCouponById(string id);
        public Task<bool> EditCoupon(CouponModel couponModel);
        public Task<bool> DeleteCoupon(string id);
    }
}
