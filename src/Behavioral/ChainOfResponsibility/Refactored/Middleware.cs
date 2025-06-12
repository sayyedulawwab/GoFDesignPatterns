namespace ChainOfResponsibility.Refactored;
public abstract class Middleware
{
    private Middleware _next;

    public Middleware LinkWith(Middleware next)
    {
        _next = next;
        return next;
    }

    public void Handle(HttpRequest request)
    {
        if (!Check(request)) return;
        _next?.Handle(request);
    }

    protected abstract bool Check(HttpRequest request);
}

