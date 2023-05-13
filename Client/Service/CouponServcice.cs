using Client.Data;
using Client.Entites;
using Client.Models;
using Client.Service.Interface;

namespace Client.Service
{
    public class CouponServcice : ICouponServcice
    {
        private readonly ApplicationDbContext _context;

        public CouponServcice( ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> SetCoupon(string couponCode, int couponPrice = 0)
        {
            var couponFirst = _context.Coupons.FirstOrDefault(x => x.couponCode == couponCode);
            if (couponFirst == null)
            {
                Coupons coupons = new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode = couponCode,
                    couponPrice = couponPrice
                };
                await _context.Coupons.AddAsync(coupons);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public  CouponModel GetCoupon(string couponCode)
        {
            var couponFirst = _context.Coupons.FirstOrDefault(x => x.couponCode == couponCode);

            if(couponFirst != null)
            {
                var counponModel = new CouponModel()
                {
                    CouponId = couponFirst.couponId,
                    CouponCode = couponFirst.couponCode,
                    CouponPrice = couponFirst.couponPrice
                };

                return counponModel;
            }

            return null;
        }
    }
}
