using AutoMapper;
using Gurmany.Services.CouponAPI.Models;
using Gurmany.Services.CouponAPI.Models.Dto;
using Microsoft.Identity.Client;

namespace Gurmany.Services.CouponAPI
{
    public class MapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
                {
                    config.CreateMap<Coupon, CouponDto>().ReverseMap();
                }
            );
            return mappingConfig;
        }
    }
}
