using System.Collections.Generic;
using System.Linq;
using PoemApp.Domain;
using PoemApp.Domain.Interfaces;

namespace PoemApp.Infrastructure.DataAccess
{
    public class PoemRepository : IObtainPoems, IWriteLines
    {
        private List<Poem> poems = new List<Poem>();

        public IEnumerable<Poem> GetAllPoems()
        {
            return poems;
        }

        public void SavePoem(Poem poem)
        {
            poems.Add(poem);
        }
    }
}