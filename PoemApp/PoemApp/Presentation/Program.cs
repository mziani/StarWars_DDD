using System;
using PoemApp.Application;
using PoemApp.Infrastructure.Adapters;
using PoemApp.Domain.Interfaces;

namespace PoemApp.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = "path/to/poems.txt";
            IObtainPoems filePoemAdapter = new FilePoemAdapter(filePath);


            PoemService poemService = new PoemService(filePoemAdapter);

            var poems = poemService.GetAllPoems();
            foreach (var poem in poems)
            {
                Console.WriteLine($"Title: {poem.Title}");
                Console.WriteLine($"Content: {poem.Content}");
                Console.WriteLine();
            }
        }
    }
}