namespace DesignPatternExamples.Mediator;

public interface IMediator
{
    TResponse Send<TResponse>(IRequest<TResponse> request);
}
