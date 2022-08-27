namespace Application.Common.Models;

public class Result<T>
{
    public bool Succeeded { get; set; }
    public string[] Errors { get; set; } = Array.Empty<string>();
    public string ResponseMessage { get; set; } = string.Empty;
    public T Payload { get; set; } = default;

    internal Result(bool succeeded)
    {
        Succeeded = succeeded;
    }

    internal Result(bool succeeded, string responseMessage)
    {
        Succeeded = succeeded;
        ResponseMessage = responseMessage;
    }

    internal Result(bool succeeded, string responseMessage, T payload)
    {
        Succeeded = succeeded;
        ResponseMessage = responseMessage;
        Payload = payload;
    }

    internal Result(bool succeeded, IEnumerable<string> errors)
    {
        Succeeded = succeeded;
        Errors = errors.ToArray();
    }

    internal Result(bool succeeded, IEnumerable<string> errors, T payload)
    {
        Succeeded = succeeded;
        Errors = errors.ToArray();
        Payload = payload;
    }

    public static Result<T> Success()
    {
        return new Result<T>(true);
    }

    public static Result<T> Success(string responseMessage)
    {
        return new Result<T>(true, responseMessage);
    }

    public static Result<T> Success(T payload)
    {
        return new Result<T>(true, string.Empty, payload);
    }

    public static Result<T> Success(string responseMsg, T payload)
    {
        return new Result<T>(true, responseMsg, payload);
    }

    public static Result<T> Failure()
    {
        return new Result<T>(false, Array.Empty<string>());
    }

    public static Result<T> Failure(IEnumerable<string> errors)
    {
        return new Result<T>(false, errors);
    }

    public static Result<T> Failure(IEnumerable<string> errors, T payload)
    {
        return new Result<T>(false, errors, payload);
    }
}
