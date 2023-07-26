using System.Collections.Generic;
using System.IO;
using System.Linq;
using PoemApp.Domain;
using PoemApp.Domain.Interfaces;

namespace PoemApp.Infrastructure.Adapters
{
    public class FilePoemAdapter : IObtainPoems
    {
        private readonly string filePath;

        public FilePoemAdapter(string filePath)
        {
            this.filePath = filePath;
        }

        public IEnumerable<Poem> GetAllPoems()
        {
            List<Poem> poems = new List<Poem>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        poems.Add(new Poem
                        {
                            Id = int.Parse(parts[0]),
                            Title = parts[1],
                            Content = parts[2]
                        });
                    }
                }
            }

            return poems;
        }
    }
}