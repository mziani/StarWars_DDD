using System.Collections.Generic;

namespace PoemApp.Domain.Interfaces
{
    public interface IObtainPoems
    {
        IEnumerable<Poem> GetAllPoems();
    }
}