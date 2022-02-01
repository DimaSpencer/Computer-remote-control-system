namespace M1.WebAPI.Middlewares;

public static class RequestExceptionHandlerMiddlewareExtensions
{
    public static IApplicationBuilder UseRequestExceptionHandler(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ReqeustExceptionHandlerMiddleware>();
    }
}