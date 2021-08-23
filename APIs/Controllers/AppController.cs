using APIs.Utilities;
using GlobalHelpers.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SharedConfig.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Controllers
{
    public class AppController : ControllerBase
    {
        public GResponse<T> Ok<T>(T data)
        {
            Response.StatusCode = StatusCodes.Status200OK;
            return new GResponse<T>
            {
                Status = "success",
                Errors = new List<string>(),
                Data = data
            };
        }
        public GResponse<T> Error<T>(List<string> errors, int statusCode = StatusCodes.Status400BadRequest)
        {
            Response.StatusCode = statusCode;
            return new GResponse<T>()
            {
                Status = "error",
                Errors = errors,
                Data = default
            };
        }
        public GResponse<T> Error<T>(string error, int statusCode = StatusCodes.Status400BadRequest)
        {
            Response.StatusCode = statusCode;
            return new GResponse<T>()
            {
                Status = "error",
                Errors = new List<string> { error },
                Data = default
            };
        }
        public GResponse<T> ExceptionHandler<T>(Func<GResponse<T>> func)
        {
            if (ModelState.IsValid)
            {
                try { return func(); }
                catch (AppException ex) { return Error<T>(ex.Message, StatusCodes.Status200OK); }
                catch (Exception) { return Error<T>(Errors.E_AN_ERROR_OCCURRED); }
            }
            else return Error<T>(Errors.E_SOMETHING_WENT_WRONG);
        }
        public async Task<GResponse<T>> ExceptionHandler<T>(Func<Task<GResponse<T>>> func)
        {
            if (ModelState.IsValid)
            {
                try { return await func(); }
                catch (AppException ex) { return Error<T>(ex.Message, StatusCodes.Status200OK); }
                catch (Exception) { return Error<T>(Errors.E_AN_ERROR_OCCURRED); }
            }
            else return Error<T>(Errors.E_SOMETHING_WENT_WRONG);
        }
    }
}
