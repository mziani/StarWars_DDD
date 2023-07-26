using System;

namespace StarWars_DDD.Application
{
    public interface IErrorHandler
    {
        void Handle(Exception ex);
    }
}