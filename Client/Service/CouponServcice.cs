using Client.Data;
using Client.Entites;
using Client.Models;
using Client.Service.Interface;
using System.Security.Policy;

namespace Client.Service
{
    public class CouponServcice : ICouponServcice
    {
        private readonly ApplicationDbContext _context;

        public CouponServcice( ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CouponModel> GetAllCoupon()
        {
            var query = _context.Coupons.Where(x => x.isDelete == false);
            List<CouponModel> coupons = new List<CouponModel>();
            
            foreach (var item in query)
            {
                CouponModel couponModel = new CouponModel();
                couponModel.CouponId = item.couponId;
                couponModel.CouponCode = item.couponCode;
                couponModel.CouponPrice = item.couponPrice;
                coupons.Add(couponModel);

            }
            return coupons;
        }

        public async Task<bool> SetCoupon(CouponModel couponModel)
        {
            var couponFirst = _context.Coupons.FirstOrDefault(x => x.couponCode == couponModel.CouponCode && x.isDelete == false);
            if (couponFirst == null)
            {
                Coupons coupons = new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode = couponModel.CouponCode,
                    couponPrice = couponModel.CouponPrice
                };
                await _context.Coupons.AddAsync(coupons);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public CouponModel GetCoupon(string couponCode)
        {
            var couponFirst = _context.Coupons.FirstOrDefault(x => x.couponCode == couponCode && x.isDelete == false);

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

            return new CouponModel();
        }
        public CouponModel GetCouponById(string id)
        {
            var couponFirst = _context.Coupons.FirstOrDefault(x => x.couponId == id && x.isDelete == false);

            if (couponFirst != null)
            {
                var counponModel = new CouponModel()
                {
                    CouponId = couponFirst.couponId,
                    CouponCode = couponFirst.couponCode,
                    CouponPrice = couponFirst.couponPrice
                };

                return counponModel;
            }

            return new CouponModel();
        }

        public async Task<bool> EditCoupon(CouponModel couponModel)
        {
            var queryCoupon = _context.Coupons.FirstOrDefault(x => x.couponId == couponModel.CouponId);

            if (queryCoupon != null)
            {
                queryCoupon.couponCode = couponModel.CouponCode;
                queryCoupon.couponPrice = couponModel.CouponPrice;
                queryCoupon.isDelete = false;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteCoupon(string id)
        {
            var queryCoupon = _context.Coupons.FirstOrDefault(x => x.couponId == id);
            
            if(queryCoupon != null)
            {
                queryCoupon.isDelete = true;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
