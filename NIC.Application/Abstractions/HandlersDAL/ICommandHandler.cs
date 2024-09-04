namespace NIC.Application.Abstractions.HandlersDAL
{
  public interface ICommandHandler<TResult, TCommand>
  {
    TResult Handle(TCommand command);
  }
}
