using System;

namespace StarWars_DDD.Application
{
    public class StarshipCommandBus
    {
        public void Execute<T>(ICommand<T> command)
        {
            try
            {
                var result = command.Execute();
                command.SuccessHandler?.Handle(result);
            }
            catch (Exception ex)
            {
                command.ErrorHandler?.Handle(ex);
            }
        }
    }
}