namespace NIC.Application.Abstractions.HandlersDAL
{
  public interface IQueryHandler<TResult, TQuery>
  {
    TResult Handle(TQuery query);
  }
}
