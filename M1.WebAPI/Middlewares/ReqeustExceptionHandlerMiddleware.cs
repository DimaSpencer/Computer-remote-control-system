using FluentValidation;
using M1.Application.Common.Exceptions;
using System.Net;
using System.Text.Json;

namespace M1.WebAPI.Middlewares;

public class ReqeustExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ReqeustExceptionHandlerMiddleware(RequestDelegate next) =>
        _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next.Invoke(context);
        }
        catch (Exception ex)
        {
            await Handle(context, ex);
        }
    }

    private Task Handle(HttpContext context, Exception ex)
    {
        var code = HttpStatusCode.InternalServerError;

        var result = string.Empty;
        switch (ex)
        {
            case ValidationException validationException:
                code = HttpStatusCode.BadRequest;
                result = JsonSerializer.Serialize(validationException.Errors);
                break;
            case EntityNotFoundException:
                code = HttpStatusCode.NotFound;
                break;
        }
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;

        if (result == string.Empty)
        {
            result = JsonSerializer.Serialize(new { error = ex.Message });
        }

        return context.Response.WriteAsync(result);
    }
}
