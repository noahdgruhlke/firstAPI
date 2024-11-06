using firstAPI.Domain.Managers.Repositories;
using firstAPI.Domain.Models.Entities;

namespace firstAPI.Domain.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepositories _bookRepositories;
        public BookService(IBookRepositories bookRepositories)
        {
            _bookRepositories = bookRepositories;
        }

        public List<BookList> GetAll()
        {
            return _bookRepositories.GetAll();
        }
    }
}
