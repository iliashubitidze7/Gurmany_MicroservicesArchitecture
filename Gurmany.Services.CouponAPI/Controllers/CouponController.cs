using AutoMapper;
using Gurmany.Services.CouponAPI.Data;
using Gurmany.Services.CouponAPI.Models;
using Gurmany.Services.CouponAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Gurmany.Services.CouponAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CouponController : ControllerBase
	{
		private readonly AppDbContext _db;
		private ResponseDto _response;
		IMapper _mapper;

		public CouponController(AppDbContext db, IMapper mapper)
		{
			_db = db;
			_mapper = mapper;
			_response = new ResponseDto();
		}

		[HttpGet]
		public ResponseDto GetAll()
		{
			try
			{
				_response.Result = _db.Coupons.ToList();
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}

		[HttpGet]
		[Route("{id:int}")]
		public ResponseDto GetById(int id)
		{
			try
			{
				Coupon obj = _db.Coupons.First(u => u.CouponId == id);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}

		[HttpGet]
		[Route("GetByCode/{code}")]
		public ResponseDto GetByCode(string code)
		{
			try
			{
				Coupon obj = _db.Coupons.First(u => u.CouponCode.ToLower() == code.ToLower());
				_response.Result = _mapper.Map<Coupon>(obj);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}

		[HttpPost]
		public ResponseDto Add(CouponDto couponDto)
		{
			try
			{
				Coupon obj = _mapper.Map<Coupon>(couponDto);
				_db.Coupons.Add(obj);
				_db.SaveChanges();

				_response.Result = _mapper.Map<CouponDto>(obj);

			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}

			return _response;
		}

		[HttpPut]
		public ResponseDto Update([FromBody] CouponDto couponDto)
		{
			try
			{
				Coupon obj = _mapper.Map<Coupon>(couponDto);
				_db.Coupons.Update(obj);
				_db.SaveChanges();

				_response.Result = _mapper.Map<CouponDto>(obj);

			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}

			return _response;
		}

		[HttpDelete]
		[Route("{id:int}")]
		public ResponseDto Delete(int id)
		{
			try
			{
				Coupon obj = _db.Coupons.First(u => u.CouponId == id);
				_db.Coupons.Remove(obj);
				_db.SaveChanges();

			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}
	}
}
