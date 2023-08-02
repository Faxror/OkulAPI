namespace OkulYönetimAPI.Business.Concrete
{
    public class ValidationResponse<T>
    {
        public bool Success { get; set; }

        public List<string> Message { get; set; }

        public T Data { get; set; }
    }
}