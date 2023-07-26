namespace StarWars_DDD.Application
{
    public interface ICommand<T>
    {
        T Execute();
        IResponseHandler<T> SuccessHandler { get; set; }
        IErrorHandler ErrorHandler { get; set; }
    }
}