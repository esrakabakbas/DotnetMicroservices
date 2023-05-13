using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FreeCourse.Shared.DTO
{
    public class ResponseDTO<T>
    {
        public T Data { get; private set; }
        [JsonIgnore]
        public int StatusCode { get; private set; }
        public bool IsSuccessful { get; private set; }
        public List<string> ErrorList { get; set; }

        //Static Factory Method
        public static ResponseDTO<T> Success(T data, int statusCode)
        {
            return new ResponseDTO<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }

        public static ResponseDTO<T> Success(int statusCode)
        {
            return new ResponseDTO<T> { Data = default(T), StatusCode = statusCode, IsSuccessful = true };
        }

        public static ResponseDTO<T> Fail(List<string> errorList, int statusCode)
        {
            return new ResponseDTO<T> { ErrorList = errorList, StatusCode = statusCode, IsSuccessful = false };
        }

        public static ResponseDTO<T> Fail(string error, int statusCode)
        {
            return new ResponseDTO<T> { ErrorList = new List<string> { error}, StatusCode = statusCode, IsSuccessful = false };
        }
    }
}
