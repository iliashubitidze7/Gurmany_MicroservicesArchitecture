using Gurmany.Web.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Gurmany.Web.Services.IServices
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
