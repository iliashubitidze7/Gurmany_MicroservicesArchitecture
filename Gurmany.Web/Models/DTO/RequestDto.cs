using Gurmany.Web.Utility;
using static Gurmany.Web.Utility.SD;

namespace Gurmany.Web.Models.DTO
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object? Data { get; set; }
        public string AccessToken { get; set; }
    }
}
