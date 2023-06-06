using CNCRM.Service.Enum;

namespace CNCRM.Service.Concrete
{
    public class ServiceResponse
    {
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }
        public bool Success { get; set; } = true;
        public ResponseType ResponseType { get; set; } = ResponseType.success;
    }
}
