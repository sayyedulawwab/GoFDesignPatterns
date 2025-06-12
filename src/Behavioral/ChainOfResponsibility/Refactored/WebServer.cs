namespace ChainOfResponsibility.Refactored;
public class WebServer
{
    private readonly Middleware _middleware;

    public WebServer(Middleware middleware)
    {
        _middleware = middleware;
    }

    public void Handle(HttpRequest request)
    {
        _middleware.Handle(request);
    }
}
