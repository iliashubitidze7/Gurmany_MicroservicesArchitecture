using System.ComponentModel.DataAnnotations;

namespace Gurmany.Services.CouponAPI.Models.Dto
{
    public class CouponDto
    {
        [Key]
        public int CouponId { get; set; }

        [Required]
        public string CouponCode { get; set; }

        [Required]
        public Double DiscountAmount { get; set; }

        public int MinAmount { get; set; }
    }
}
