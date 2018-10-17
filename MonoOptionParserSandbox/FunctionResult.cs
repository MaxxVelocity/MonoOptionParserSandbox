using System;
using System.Collections.Generic;
using System.Text;

namespace MonoOptionParserSandbox
{
    public class FunctionResult<T>
    {
        public bool Successful { get; private set; }

        public T Value { get; private set; }

        public Exception Error { get; private set; }

        private FunctionResult(bool success)
        {
            this.Successful = success;
        }

        private FunctionResult(bool success, T value)
        {
            this.Successful = success;
            this.Value = value;
        }

        private FunctionResult(Exception exception)
        {
            this.Successful = false;
            this.Error = exception;
        }

        public static FunctionResult<T> Success(T value)
        {
            return new FunctionResult<T>(true, value);
        }

        public static FunctionResult<T> Failure()
        {
            return new FunctionResult<T>(false);
        }

        public static FunctionResult<T> Exception(Exception exception)
        {
            return new FunctionResult<T>(exception);
        }
    }

    public static class FunctionalExtensions
    {
        public static FunctionResult<T> ToFunctionResult<T>(this Exception exception)
        {
            return FunctionResult<T>.Exception(exception);
        }
    }
}
