namespace StatusGizi.Domain.Commons;

public class Result
{
    public bool IsSuccess { get; }
    public Error Error { get; }

    public bool IsFailure => !IsSuccess;

    private Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None)
            throw new ArgumentException("Success Result Error's must be Error.None");

        if (!isSuccess && error == Error.None)
            throw new ArgumentException("Failure Result Error's must not be Error.None");

        IsSuccess = isSuccess;
        Error = error;
    }

    public static Result Success() => new(true, Error.None);

    public static implicit operator Result(Error error) => new(false, error);
}

public class Result<T>
{
    private readonly T? _value;

    public bool IsSuccess { get; }
    public Error Error { get; }

    public T Value => IsSuccess ? _value! : throw new InvalidOperationException("Try to access value of failure Result");
    public bool IsFailure => !IsSuccess;

    private Result(T? value, bool isSuccess, Error error)
    {
        if (isSuccess && (error != Error.None || value is null))
            throw new ArgumentException("Success result error's must be Error.None and value must be not null");

        if (!isSuccess && (error == Error.None || value is not null))
            throw new ArgumentException("Failure result error's must not Error.None and value must be null");

        _value = value;
        IsSuccess = isSuccess;
        Error = error;
    }

    public static implicit operator Result<T>(T value) => new(value, true, Error.None);

    public static implicit operator Result<T>(Error error) => new(default, false, error);
}