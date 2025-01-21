using Gurmany.Web.Utility;

namespace Gurmany.Web.Models.DTO
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public string Message { get; set; } = "";
        public bool IsSuccess { get; set; } = true;
    }
}
