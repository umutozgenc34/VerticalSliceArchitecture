using System.Net;
using System.Text.Json.Serialization;

namespace Shared.Responses;

public class ServiceResult
{
    public string? Message { get; set; }

    [JsonIgnore]
    public HttpStatusCode Status { get; set; }

    [JsonIgnore]
    public bool Success { get; set; }

    public static ServiceResult SuccessResult(string message, HttpStatusCode status = HttpStatusCode.OK)
    {
        return new ServiceResult()
        {
            Message = message,
            Status = status,
            Success = true
        };
    }

    public static ServiceResult FailResult(string message, HttpStatusCode status = HttpStatusCode.BadRequest)
    {
        return new ServiceResult()
        {
            Message = message,
            Status = status,
            Success = false
        };
    }
}

public class ServiceResult<T> : ServiceResult
{
    public T? Data { get; set; }
    [JsonIgnore] public string? UrlAsCreated { get; set; }

    public static ServiceResult<T> SuccessResult(T data, string message, HttpStatusCode status = HttpStatusCode.OK)
    {
        return new ServiceResult<T>()
        {
            Data = data,
            Message = message,
            Status = status,
            Success = true
        };
    }

    public static ServiceResult<T> SuccessAsCreated(T data, string message, string urlAsCreated)
    {
        return new ServiceResult<T>()
        {
            Data = data,
            Message = message,
            Status = HttpStatusCode.Created,
            UrlAsCreated = urlAsCreated,
            Success = true
        };
    }

    public static ServiceResult<T> FailResult(string message, HttpStatusCode status = HttpStatusCode.BadRequest)
    {
        return new ServiceResult<T>()
        {
            Data = default,
            Message = message,
            Status = status,
            Success = false
        };
    }
}