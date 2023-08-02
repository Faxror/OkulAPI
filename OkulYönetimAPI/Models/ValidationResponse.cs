namespace OkulYönetimAPI.Models
{
    public class ValidationResponse<T>
    {
        public bool Success { get; set; }
        public Dictionary<string, string> Errors { get; set; }
        public T IsSuccess { get; set; }
    }
}
