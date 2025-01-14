using Gurmany.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Gurmany.Services.CouponAPI.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base (options)
        {
            
        }

        DbSet<Coupon> Coupons {  get; set; }
    }

    
}
