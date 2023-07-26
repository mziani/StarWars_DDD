using System;
using PoemApp.Domain;
using PoemApp.Domain.Interfaces;

namespace PoemApp.Application
{
    public class PoemController
    {
        private readonly PoemService poemService;
        private readonly IWriteLines poemWriter;

        public PoemController(PoemService poemService, IWriteLines poemWriter)
        {
            this.poemService = poemService;
            this.poemWriter = poemWriter;
        }

        public void DisplayAllPoems()
        {
            var poems = poemService.GetAllPoems();
            foreach (var poem in poems)
            {
                Console.WriteLine($"Title: {poem.Title}");
                Console.WriteLine($"Content: {poem.Content}");
                Console.WriteLine();
            }
        }

        public void WriteNewPoem(string title, string content)
        {
            var newPoem = new Poem
            {
                Title = title,
                Content = content
            };

            poemWriter.SavePoem(newPoem);

            Console.WriteLine("New poem saved successfully!");
        }
    }
}