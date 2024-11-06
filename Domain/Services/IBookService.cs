using firstAPI.Domain.Models.Entities;

namespace firstAPI.Domain.Services
{
    public interface IBookService
    {
        List<BookList> GetAll();
    }
}
