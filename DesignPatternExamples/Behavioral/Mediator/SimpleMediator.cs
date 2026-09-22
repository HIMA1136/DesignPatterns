namespace DesignPatternExamples.Mediator;

public class SimpleMediator : IMediator
{
    private readonly Dictionary<Type, object> _handlers = new();

    public void RegisterHandler<TRequest, TResponse>(IRequestHandler<TRequest, TResponse> handler)
        where TRequest : IRequest<TResponse>
    {
        _handlers[typeof(TRequest)] = handler;
    }

    public TResponse Send<TResponse>(IRequest<TResponse> request)
    {
        if (!_handlers.TryGetValue(request.GetType(), out var handler))
        {
            throw new InvalidOperationException($"No handler registered for {request.GetType().Name}.");
        }

        return ((dynamic)handler).Handle((dynamic)request);
    }
}
