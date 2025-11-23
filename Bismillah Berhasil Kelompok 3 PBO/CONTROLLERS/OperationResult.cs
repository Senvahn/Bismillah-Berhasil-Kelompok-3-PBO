namespace SuwarSuwirApp.Controllers
{
    // Generic result wrapper untuk operasi CRUD / transaksi
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class OperationResult<T> : OperationResult
    {
        public T Data { get; set; }

        public static OperationResult<T> SuccessResult(T data, string message = "")
        {
            return new OperationResult<T> { Success = true, Message = message, Data = data };
        }

        public static OperationResult<T> Fail(string message)
        {
            return new OperationResult<T> { Success = false, Message = message, Data = default(T) };
        }
    }
}
