namespace mentorApi.Models
{
    public class ResponseModel<T>
    {
        public  T Data { get; set; }
        public  int  statusCode { get; set; }
    }
}
