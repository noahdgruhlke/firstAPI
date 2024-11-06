using firstAPI.Domain.Models.Entities;

namespace firstAPI.Domain.Managers.Repositories
{
    public interface IBookRepositories
    {
        List<BookList> GetAll();
    }
}
