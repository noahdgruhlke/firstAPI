using firstAPI.Domain.Managers.Repositories;
using firstAPI.Domain.Models.Entities;

namespace firstAPI.Domain.Managers.Repositories
{
    public class BookRepositories : IBookRepositories
    {
        private static readonly string[] Summaries = new[]
        {
            "Old", "New", "Updated"
        };

        public List<BookList> GetAll()
        {
            return Enumerable.Range(1, 5).Select(index => new BookList
            {
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToList();
        }
    }
}
