using System.Collections.Generic;
using PoemApp.Domain;
using PoemApp.Domain.Interfaces;

namespace PoemApp.Application
{
    public class PoemService
    {
        private readonly IObtainPoems poemProvider;

        public PoemService(IObtainPoems poemProvider)
        {
            this.poemProvider = poemProvider;
        }

        public IEnumerable<Poem> GetAllPoems()
        {
            return poemProvider.GetAllPoems();
        }
    }
}