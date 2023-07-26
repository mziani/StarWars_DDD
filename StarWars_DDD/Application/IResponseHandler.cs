namespace StarWars_DDD.Application
{
    public interface IResponseHandler<T>
    {
        void Handle(T response);
    }
}