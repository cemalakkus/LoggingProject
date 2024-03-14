namespace CQRSProject.Application.Wrappers;

public class ApiResponse<T>
{
    public bool Succeeded { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    public List<string> Errors { get; set; }

    public ApiResponse()
    {

    }
    public ApiResponse(T data, string message = null)
    {
        Succeeded = true;
        Message = message;
        Data = data;
    }

    public ApiResponse(string message = null)
    {
        Succeeded = false;
        Message = message;
    }

    //public static ApiResponse<T> Fail(string errorMessage)
    //{
    //    return new ApiResponse<T> { Succeeded = false, Message = errorMessage };
    //}
    //public static ApiResponse<T> Success(T data)
    //{
    //    return new ApiResponse<T> { Succeeded = true, Data = data };
    //}
}
